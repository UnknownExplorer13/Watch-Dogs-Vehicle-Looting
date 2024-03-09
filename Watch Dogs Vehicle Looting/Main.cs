using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using GTA;
using GTA.Math;
using GTA.UI;
using Watch_Dogs_Vehicle_Looting.Classes;

namespace Watch_Dogs_Vehicle_Looting
{
	public class Main : Script
	{
		// Looted vehicles (to prevent re-looting)
		private List<Vehicle> lootedVehicles = new List<Vehicle>();

		// Initialization
		public Main()
		{
			Mod.VerifyFileStructure();
			Mod.LoadConfig();
			Mod.LoadAddons();
			Mod.CreateBlips();
			InventoryManagement.LoadInventories();

			Tick += OnTick;
			Aborted += Mod.OnAbort;
			KeyDown += OnKeyDown;

			Notification.Show(Localization.Localize.GetLangEntry("Initialized"));
		}

		private void OnTick(object sender, EventArgs e)
		{
			// Draw 3d markers at each pawn shop if necessary
			if (Mod.config.settings.pawnShop3dMarkers)
			{
				foreach (PawnShop shop in Mod.config.pawnShops)
				{
					if (Utils.PlayerIsInRange(new Vector3(shop.markerX, shop.markerY, shop.markerZ), 150f))
						shop.DrawShopMarker();
				}
			}


			// If the player is driving a vehicle, try to loot it
			if (Game.Player.Character.IsInVehicle() && Game.Player.Character.SeatIndex == VehicleSeat.Driver)
			{
				Vehicle playerVehicle = Utils.GetPlayersCurrentVehicle();

				// If the vehicle's class is not part of the blocked class list then loot it
				if (!lootedVehicles.Contains(playerVehicle) && !Mod.blockedClassList.Contains(playerVehicle.ClassType.ToString()))
				{
					Wait(2500);
					if (new Random().Next(1, 100) <= 75) Mod.LootVehicle(playerVehicle);
					lootedVehicles.Add(playerVehicle);
				}
				// If the vehicle's class is part of the blocked class list but the model is in the exception list then loot it
				else if (!lootedVehicles.Contains(playerVehicle) && Mod.blockedClassList.Contains(playerVehicle.ClassType.ToString()) && Mod.blockedClassExceptions.Contains(playerVehicle.Model))
				{
					Wait(2500);
					if (new Random().Next(1, 100) <= 75) Mod.LootVehicle(playerVehicle);
					lootedVehicles.Add(playerVehicle);
				}
			}
			// Otherwise, display the pawnshop sell message if necessary
			else
			{
				Inventory inventory = InventoryManagement.GetInventory((PedHash)Game.Player.Character.Model.GetHashCode());

				foreach (PawnShop shop in Mod.config.pawnShops)
				{
					// Player inside the pawn shop marker and has items to sell
					if (Utils.PlayerIsInRange(new Vector3(shop.markerX, shop.markerY, shop.markerZ), 1.25f) && inventory.pawnItems.Count >= 1)
					{
						if (!Utils.PlayerIsWanted()) // Player is not wanted so we show the sell message
						{
							StringBuilder subtitle = new StringBuilder(Localization.Localize.GetLangEntry("CanSell"));
							subtitle.Replace("{inventory.totalValue}", $"{inventory.totalValue}");

							GTA.UI.Screen.ShowSubtitle(subtitle.ToString(), 1);
						}
						else // Player is wanted so we show the cannot sell when wanted message
						{
							GTA.UI.Screen.ShowSubtitle(Localization.Localize.GetLangEntry("CantSell"), 1);
						}
					}
				}
			}
		}

		private void OnKeyDown(object sender, KeyEventArgs e)
		{
			// Developer commands
			if (Mod.config.settings.devMode)
			{
				if (e.KeyCode == Keys.X && e.Shift) Mod.LootVehicle(null); // Get random loot

				if (e.KeyCode == Keys.L && e.Shift) Mod.CreatePawnShop(Game.Player.Character.Position);

				if (e.KeyCode == Keys.Add && e.Shift)
				{
					if (Game.Player.Character.IsInVehicle())
					{
						Vehicle playerVehicle = Utils.GetPlayersCurrentVehicle();

						Mod.AddVehModelException(playerVehicle.ClassType, playerVehicle.DisplayName);
					}
					else Notification.Show("Must be in a vehicle to add vehicle model to exception list");
				}
			}

			// If the pawnshop use key is pressed
			if (e.KeyCode == Keys.E && !Game.Player.Character.IsInVehicle() && !Utils.PlayerIsWanted())
			{
				foreach(PawnShop shop in Mod.config.pawnShops)
				{
					// If the player is at a pawn shop
					Vector3 markerPos = new Vector3(shop.markerX, shop.markerY, shop.markerZ);
					Inventory inventory = InventoryManagement.GetInventory((PedHash)Game.Player.Character.Model.GetHashCode());

					if (Utils.PlayerIsInRange(markerPos, 1.25f) && inventory.pawnItems.Count >= 1)
					{
						// Sell every item
						int itemCount = inventory.pawnItems.Count;
						int itemValue = inventory.totalValue;

						Utils.PlaySellItemCinematic();

						bool caughtByCops = false;
						if (new Random().Next(0, 100) >= 80) caughtByCops = true;

						if (!caughtByCops) // If the item is actually sold
						{
							inventory.pawnItems.Clear();
							inventory.totalValue = 0;
							InventoryManagement.SaveInventory(inventory);
							World.CurrentTimeOfDay = new TimeSpan(World.CurrentTimeOfDay.Hours + new Random().Next(1, itemCount), new Random().Next(1, 59), new Random().Next(1, 59));
							Game.Player.Money = Game.Player.Money + itemValue;

							StringBuilder notification = new StringBuilder(Localization.Localize.GetLangEntry("SoldItems"));
							notification.Replace("{itemCount}", $"{itemCount}");
							notification.Replace("{itemValue}", $"{itemValue}");

							if (itemCount > 1)
							{
								Notification.Show(notification.ToString());
							}
							else if (itemCount == 1)
							{
								notification.Replace("items", "item");

								Notification.Show(notification.ToString());
							}
						} 
						else // If the cops are called
						{
							Notification.Show(Localization.Localize.GetLangEntry("CopsCalled"));
							Game.Player.WantedLevel = 2;
						}
					}
				}
			}
		}
	}
}
