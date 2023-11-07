﻿using System;
using System.Collections.Generic;
using System.IO;
using GTA;
using GTA.Math;
using GTA.Native;
using Newtonsoft.Json;
using Watch_Dogs_Vehicle_Looting.Classes;
using Watch_Dogs_Vehicle_Looting.Classes.Items;
using Watch_Dogs_Vehicle_Looting.Localization;
using System.Text;

namespace Watch_Dogs_Vehicle_Looting
{
	public class Mod
	{
		// Configuration stuff
		public static Configuration config;
		public static List<Item> items;
		public static List<Food> food;
		public static List<Classes.Items.Weapon> weapons;

		// Directories
		public static string resourceDir = "scripts\\Watch Dogs Vehicle Looting";
		public static string itemDir = $"{resourceDir}\\Items";

		// Files
		public static string pawnItemsJson = $"{itemDir}\\pawnItems.json";
		public static string foodItemsJson = $"{itemDir}\\foodItems.json";
		public static string weaponsJson = $"{itemDir}\\weapons.json";
		public static string modConfig = $"{resourceDir}\\modConfig.json";
		public static string inventories = $"{resourceDir}\\inventories.json";

		// Misc
		public static List<Blip> blips = new List<Blip>();
		public static List<string> blockedClassList = new List<string>();
		public static List<Model> blockedClassExceptions = new List<Model>();

		public static void VerifyFileStructure()
		{
			// Ensure that all necessary directories and files exist
			if (!Directory.Exists(resourceDir)) Directory.CreateDirectory(resourceDir);
			if (!Directory.Exists(itemDir)) Directory.CreateDirectory(itemDir);

			// Items
			if (!File.Exists(pawnItemsJson)) File.WriteAllText(pawnItemsJson, JsonConvert.SerializeObject(Defaults.defaultItems, Formatting.Indented));
			if (!File.Exists(foodItemsJson)) File.WriteAllText(foodItemsJson, JsonConvert.SerializeObject(Defaults.defaultFood, Formatting.Indented));
			if (!File.Exists(weaponsJson)) File.WriteAllText(weaponsJson, JsonConvert.SerializeObject(Defaults.defaultWeapons, Formatting.Indented));

			// Configuration & Inventory
			if (!File.Exists(modConfig)) File.WriteAllText(modConfig, JsonConvert.SerializeObject(new Configuration() { pawnShops = Defaults.defaultShops, blockedClasses = Defaults.defaultBlockedClasses, settings = new Settings() }, Formatting.Indented));
			if(!File.Exists(inventories)) File.WriteAllText(inventories, JsonConvert.SerializeObject(new List<Inventory>(), Formatting.Indented));
		}

		public static void LoadConfig()
		{
			// Deserialize all of the json files
			config = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(modConfig));
			items = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(pawnItemsJson));
			food = JsonConvert.DeserializeObject<List<Food>>(File.ReadAllText(foodItemsJson));
			weapons = JsonConvert.DeserializeObject<List<Classes.Items.Weapon>>(File.ReadAllText(weaponsJson));

			// Iterate over each blocked class and its exceptions and add them to lists
			foreach (BlockedClass blocked in config.blockedClasses)
			{
				blockedClassList.Add(new string(blocked.className.ToCharArray()));
				foreach (string model in blocked.modelExceptions) blockedClassExceptions.Add(new Model(model));
			}
		}

		public static void CreateBlips()
		{
			// Iterate over each pawnshop and create a blip
			foreach(PawnShop shop in config.pawnShops)
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
		}

		public static void LootVehicle(Vehicle veh)
		{
			Random r = new Random();
			Inventory inventory = InventoryManagement.GetInventory((PedHash)Game.Player.Character.Model.GetHashCode());

			// Determine the loot item
			string itemName = "";
			ItemType type = RandomEnumValue<ItemType>();
			if(type == ItemType.pawnItem)
			{
				Item item = items[r.Next(items.Count)];
				string localItemName = Localization.Localize.GetLangEntry(item.name);
				if(item.canBeSold) // Add item to player inventory if it can be sold
				{
					itemName = localItemName + " ($" + item.value + ")";
					inventory.pawnItems.Add(item);
				}
				else itemName = localItemName;  // Remove the " ($value)" part from the vehicle looted notification
				inventory.totalValue += item.value;
				InventoryManagement.SaveInventory(inventory);
			}
			else if(type == ItemType.food)
			{
				Food foodItem = food[r.Next(food.Count)];
				string localFoodItemName = Localization.Localize.GetLangEntry(foodItem.name);
				itemName = localFoodItemName;
				if (foodItem.healsPlayer) Game.Player.Character.Health = Game.Player.Character.MaxHealth;
			}
			else if(type == ItemType.weapon)
			{
				Classes.Items.Weapon weapon = weapons[r.Next(weapons.Count)];
				if (Game.Player.Character.Weapons.HasWeapon(weapon.weaponHash))
				{
					LootVehicle(veh);
					return;
				}
				string localWeaponName = Localization.Localize.GetLangEntry(weapon.weaponName);
				itemName = localWeaponName;
				Weapon(weapon.weaponHash);
			}
			else if(type == ItemType.money)
			{
				int amount = r.Next(config.settings.money.minMoney, config.settings.money.maxMoney);
				itemName = $"${amount}";
				Game.Player.Money += amount;
			}

			StringBuilder notification = new StringBuilder (Localization.Localize.GetLangEntry("VehicleLooted"));
			notification.Replace("{itemName}", $"{itemName}");
			UI.Notify(notification.ToString());
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
			foreach (Blip blip in blips) blip.Remove();
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