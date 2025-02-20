﻿using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using GTA;
using GTA.Math;
using GTA.UI;
using Watch_Dogs_Vehicle_Looting.Classes;
using Watch_Dogs_Vehicle_Looting.Classes.Items;

namespace Watch_Dogs_Vehicle_Looting
{
	public class Mod
	{
		// Configuration stuff
		public static Configuration config;
		public static List<Food> food;
		public static List<Item> items;
		public static List<Classes.Items.Weapon> weapons;

		// Directories
		public static string resourceDir = "scripts\\Watch Dogs Vehicle Looting";
		public static string itemDir = $"{resourceDir}\\Items";
		public static string addonDir = $"{resourceDir}\\Addons";

		// Files
		public static string modConfig = $"{resourceDir}\\modConfig.json";
		public static string inventories = $"{resourceDir}\\inventories.json";
		public static string foodItemsJson = $"{itemDir}\\foodItems.json";
		public static string pawnItemsJson = $"{itemDir}\\pawnItems.json";
		public static string weaponsJson = $"{itemDir}\\weapons.json";

		// Misc
		public static List<Blip> blips = new List<Blip>();
		public static List<string> blockedClassList = new List<string>();
		public static List<Model> blockedClassExceptions = new List<Model>();

		public static void VerifyFileStructure()
		{
			// Ensure that all necessary directories and files exist
			if (!Directory.Exists(resourceDir)) Directory.CreateDirectory(resourceDir);
			if (!Directory.Exists(itemDir)) Directory.CreateDirectory(itemDir);
			if (!Directory.Exists(addonDir)) Directory.CreateDirectory(addonDir);

			// Items
			if (!File.Exists(foodItemsJson)) File.WriteAllText(foodItemsJson, JsonConvert.SerializeObject(Defaults.defaultFood, Formatting.Indented));
			if (!File.Exists(pawnItemsJson)) File.WriteAllText(pawnItemsJson, JsonConvert.SerializeObject(Defaults.defaultItems, Formatting.Indented));
			if (!File.Exists(weaponsJson)) File.WriteAllText(weaponsJson, JsonConvert.SerializeObject(Defaults.defaultWeapons, Formatting.Indented));

			// Configuration & Inventory
			if (!File.Exists(modConfig)) File.WriteAllText(modConfig, JsonConvert.SerializeObject(new Configuration() { pawnShops = Defaults.defaultShops, blockedClasses = Defaults.defaultBlockedClasses, settings = new Settings() }, Formatting.Indented));
			if (!File.Exists(inventories)) File.WriteAllText(inventories, JsonConvert.SerializeObject(new List<Inventory>(), Formatting.Indented));
		}

		public static void LoadConfig()
		{
			// Deserialize all of the json files
			config = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(modConfig));
			food = JsonConvert.DeserializeObject<List<Food>>(File.ReadAllText(foodItemsJson));
			items = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(pawnItemsJson));
			weapons = JsonConvert.DeserializeObject<List<Classes.Items.Weapon>>(File.ReadAllText(weaponsJson));

			// Iterate over each blocked class and its exceptions and add them to lists
			foreach (BlockedClass blocked in config.blockedClasses)
			{
				blockedClassList.Add(new string(blocked.className.ToCharArray()));
				foreach (string model in blocked.modelExceptions) blockedClassExceptions.Add(new Model(model));
			}
		}

		public static void LoadAddons()
		{
			string[] dirs = Directory.GetDirectories(addonDir); // Get all directories inside the addon directory
			List<string> addons = new List<string>();
			bool foundAddons = false;

			// Make sure addon directories exist before continuing
			if (dirs.Length != 0)
			{
				// There are addons installed
				foundAddons = true;

				// Look for addon files inside addon directories
				foreach (string dir in dirs)
				{
					// Isolate the addon name
					string addonName = dir.Substring(dir.LastIndexOf('\\') + 1);

					// Store addon file's paths if they exist
					addons.AddRange(Directory.GetFiles(dir, $"{addonName}_foodItems.json"));
					addons.AddRange(Directory.GetFiles(dir, $"{addonName}_pawnItems.json"));
				}
			}

			// Check if addons have been found
			if (foundAddons)
			{
				// Make sure addon files exist before continuing
				if (addons.Count != 0)
				{
					// Loop through each addon file
					foreach (string addon in addons)
					{
						// Deserialize json file and add to correct list
						if (addon.EndsWith("foodItems.json")) food.AddRange(JsonConvert.DeserializeObject<List<Food>>(File.ReadAllText(addon)));
						else if (addon.EndsWith("pawnItems.json")) items.AddRange(JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(addon)));
					}
				}
			}
		}

		public static void CreateBlips()
		{
			// Iterate over each pawnshop and create a blip
			foreach (PawnShop shop in config.pawnShops)
			{
				Blip newBlip = World.CreateBlip(new Vector3(shop.markerX, shop.markerY, shop.markerZ));
				newBlip.IsShortRange = true;
				newBlip.Sprite = BlipSprite.DollarBill;
				newBlip.Color = BlipColor.Green;
				newBlip.Name = Localization.Localize.GetLangEntry("PawnShop");

				blips.Add(newBlip);
			}
		}

		public static void CreatePawnShop(Vector3 location)
		{
			// Create the pawnshop blip
			Blip newBlip = World.CreateBlip(location);
			newBlip.IsShortRange = true;
			newBlip.Sprite = BlipSprite.DollarBill;
			newBlip.Color = BlipColor.Green;
			newBlip.Name = Localization.Localize.GetLangEntry("PawnShop");

			PawnShop shop = new PawnShop()
			{
				displayName = World.GetStreetName(location) + Localization.Localize.GetLangEntry("Pawn"),
				markerX = location.X,
				markerY = location.Y,
				markerZ = location.Z
			};

			// Add the blip and shop
			config.pawnShops.Add(shop);
			blips.Add(newBlip);

			// Save the configuration json
			File.WriteAllText(modConfig, JsonConvert.SerializeObject(config, Formatting.Indented));

			Notification.Show($"Created pawn shop on \"{World.GetStreetName(location)}\"");
		}

		public static void AddVehModelException(VehicleClass vehClass, string vehModel)
		{
			string strClass = vehClass.ToString();
			string strModel = vehModel.ToLower();
			BlockedClass blockClass = null;

			// Iterate over each blocked class to find the right one
			foreach (BlockedClass blocked in config.blockedClasses)
			{
				if (blocked.className == strClass) blockClass = blocked;
			}

			// Make sure the BlockedClass is not null before continuing; If null, notify the player that the vehicle's class is not blocked
			if (blockClass != null)
			{
				// Add model to exception list if it's not already there
				if (!blockClass.modelExceptions.Contains(strModel))
				{
					// Add the model
					blockClass.modelExceptions.Add(strModel);
					blockedClassExceptions.Add(new Model(strModel));

					// Save the configuration json
					File.WriteAllText(modConfig, JsonConvert.SerializeObject(config, Formatting.Indented));

					Notification.Show($"\"{strModel}\" added to \"{blockClass.className}\" model exception list");
				}
				else Notification.Show($"\"{strModel}\" is already an exception of the \"{blockClass.className}\" vehicle class");
			}
			else Notification.Show($"\"{strClass}\" is not part of an excluded class");
		}

		public static void LootVehicle(Vehicle veh)
		{
			Random r = new Random();
			Inventory inventory = InventoryManagement.GetInventory((PedHash)Game.Player.Character.Model.GetHashCode());

			// Determine the loot item
			string itemName = "";
			ItemType type = RandomEnumValue<ItemType>();

			#region Pawn Item
			if (type == ItemType.pawnItem)
			{
				Item item = items[r.Next(items.Count)];
				string localItemName = Localization.Localize.GetLangEntry(item.name);

				if (item.canBeSold) // Add item to player inventory if it can be sold
				{
					itemName = localItemName + " ($" + item.value + ")";
					inventory.pawnItems.Add(item);
				}
				else itemName = localItemName;  // Remove the " ($value)" part from the vehicle looted notification

				inventory.totalValue += item.value;
				InventoryManagement.SaveInventory(inventory);
			}
			#endregion
			#region Food
			else if (type == ItemType.food)
			{
				Food foodItem = food[r.Next(food.Count)];
				itemName = Localization.Localize.GetLangEntry(foodItem.name);

				if (foodItem.healsPlayer && Game.Player.Character.Health != Game.Player.Character.MaxHealth)
				{
					// Heal player by foodItem's healValue or to max health if healValue is "healMax"
					switch (foodItem.healValue)
					{
						case "healSmall":
							{
								Game.Player.Character.Health += config.settings.foodHealing.healSmall;
								break;
							}
						case "healMedium":
							{
								Game.Player.Character.Health += config.settings.foodHealing.healMedium;
								break;
							}
						case "healLarge":
							{
								Game.Player.Character.Health += config.settings.foodHealing.healLarge;
								break;
							}
						case "healMax":
							{
								Game.Player.Character.Health = Game.Player.Character.MaxHealth;
								break;
							}

						// Assume item doesn't actually heal and a mistake has been made in the item's setup
						default:
							{
								break;
							}
					}
				}
			}
			#endregion
			#region Weapon
			else if (type == ItemType.weapon)
			{
				Classes.Items.Weapon weapon = weapons[r.Next(weapons.Count)];

				// If player has weapon then reroll LootVehicle()
				if (Game.Player.Character.Weapons.HasWeapon(weapon.weaponHash))
				{
					LootVehicle(veh);
					return;
				}

				itemName = Localization.Localize.GetLangEntry(weapon.weaponName);
				Weapon(weapon.weaponHash);
			}
			#endregion
			#region Money
			else if (type == ItemType.money)
			{
				int amount = r.Next(config.settings.money.minMoney, config.settings.money.maxMoney);
				itemName = $"${amount}";
				Game.Player.Money += amount;
			}
			#endregion

			StringBuilder notification = new StringBuilder(Localization.Localize.GetLangEntry("VehicleLooted"));
			notification.Replace("{itemName}", $"{itemName}");
			Notification.Show(notification.ToString());
		}

		private static void Weapon(WeaponHash Weapon)
		{
			// If the player does not have the weapon, give one to them
			if (!Game.Player.Character.Weapons.HasWeapon(Weapon))
			{
				Game.Player.Character.Weapons.Give(Weapon, 0, true, true);
			}

			// Then, select the weapon and give 2 magazines
			Game.Player.Character.Weapons.Select(Weapon);
			Game.Player.Character.Weapons.Current.Ammo += (Game.Player.Character.Weapons.Current.MaxAmmoInClip * 2);
		}

		static T RandomEnumValue<T>()
		{
			var v = Enum.GetValues(typeof(T));
			return (T)v.GetValue(new Random().Next(v.Length));
		}

		internal static void OnAbort(object sender, EventArgs e)
		{
			// Iterate over and remove each blip
			foreach (Blip blip in blips) blip.Delete();
		}
	}

	enum ItemType
	{
		pawnItem,
		weapon,
		food,
		money
	}
}