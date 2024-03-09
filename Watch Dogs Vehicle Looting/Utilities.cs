using System.Drawing;
using GTA;
using GTA.Math;
using GTA.UI;
using Watch_Dogs_Vehicle_Looting.Classes;

namespace Watch_Dogs_Vehicle_Looting
{
	public static class Utils
	{
		public static void PlaySellItemCinematic()
		{
			Screen.FadeOut(1000);
			Game.Player.Character.IsPositionFrozen = true;
			Script.Wait(1500);
			Game.Player.Character.IsPositionFrozen = false;
			Screen.FadeIn(1000);
		}

		public static void DrawShopMarker(this PawnShop shop)
		{
			Vector3 position = new Vector3(shop.markerX, shop.markerY, shop.markerZ - shop.markerZ / shop.markerZ);
			World.DrawMarker(MarkerType.VerticalCylinder, position, Vector3.Zero, Vector3.Zero, new Vector3(1.5f, 1.5f, 0.5f), Color.Yellow);
		}

		public static bool PlayerIsWanted()
		{
			if (Game.Player.WantedLevel != 0) return true;

			return false;
		}

		public static bool PlayerIsInRange(Vector3 position, float range)
		{
			if (World.GetDistance(Game.Player.Character.Position, position) <= range) return true;

			return false;
		}

		public static Vehicle GetPlayersCurrentVehicle()
		{
			return Game.Player.Character.CurrentVehicle;
		}
	}
}