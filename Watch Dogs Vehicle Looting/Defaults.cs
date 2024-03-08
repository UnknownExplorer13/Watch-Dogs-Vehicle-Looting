using System.Collections.Generic;
using GTA;
using Watch_Dogs_Vehicle_Looting.Classes;
using Watch_Dogs_Vehicle_Looting.Classes.Items;

namespace Watch_Dogs_Vehicle_Looting
{
	public class Defaults
	{
		// Define all of the default pawn items as localization values
		public static List<Item> defaultItems = new List<Item>()
		{
			#region Generic
			new Item()
			{
				name = "GenericMagazine1",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCoin",
				value = 125,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericSkateboard",
				value = 135,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCarLube1",
				value = 10,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCarLube3",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCarLube2",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCigaretteCarton1",
				value = 75,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCigaretteCarton2",
				value = 65,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCreditCard1",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericGlassPipe",
				value = 10,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCreditCard2",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericGolfClubCard",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericMMIPapers",
				value = 20,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCigarettePack1",
				value = 7,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCigarettePack2",
				value = 5,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericTrafficCard",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericBillOfSale",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericCreditCard3",
				value = 5,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericMagazine2",
				value = 10,
				canBeSold = true
			},
			new Item()
			{
				name = "GenericToothpaste",
				value = 3,
				canBeSold = true
			},
			#endregion
			#region Airline Tickets
			new Item()
			{
				name = "AirlineTicket1",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "AirlineTicket2",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "AirlineTicket3",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "AirlineTicket4",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "AirlineTicket5",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "AirlineTicket6",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "AirlineTicket7",
				value = 1500,
				canBeSold = true
			},
			#endregion
			#region Alcohol
			new Item()
			{
				name = "AlcoholItem1",
				value = 75,
				canBeSold = true
			},
			new Item()
			{
				name = "AlcoholItem2",
				value = 750,
				canBeSold = true
			},
			new Item()
			{
				name = "AlcoholItem3",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "AlcoholItem4",
				value = 25,
				canBeSold = true
			},
			new Item()
			{
				name = "AlcoholItem5",
				value = 300,
				canBeSold = true
			},
			new Item()
			{
				name = "AlcoholItem6",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "AlcoholItem7",
				value = 10,
				canBeSold = true
			},
			new Item()
			{
				name = "AlcoholItem8",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "AlcoholItem9",
				value = 25,
				canBeSold = true
			},
			#endregion
			#region Clothing
			new Item()
			{
				name = "ClothingRing1",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "ClothingBrandiFruit1",
				value = 750,
				canBeSold = true
			},
			new Item()
			{
				name = "ClothingBrandiFruit2",
				value = 300,
				canBeSold = true
			},
			new Item()
			{
				name = "ClothingBrandKronos1",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "ClothingBrandKronox1",
				value = 125,
				canBeSold = true
			},
			new Item()
			{
				name = "ClothingBrandPanoramic1",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "ClothingBrandPeckerwood1",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "ClothingRing2",
				value = 75,
				canBeSold = true
			},
			new Item()
			{
				name = "ClothingRing3",
				value = 250,
				canBeSold = true
			},
			#endregion
			#region Drugs
			new Item()
			{
				name = "DrugsMDMA1",
				value = 20,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsMDMA2",
				value = 40,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsMDMA3",
				value = 60,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsBottle1",
				value = 1000,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsBox1",
				value = 250,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsBox2",
				value = 5,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsBox3",
				value = 300,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsBox4",
				value = 5,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsBox5",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsBox6",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsCocaine1",
				value = 120,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsCocaine2",
				value = 450,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsCocaine3",
				value = 3360,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsCrackCocaine1",
				value = 120,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsCrackCocaine2",
				value = 450,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsCrackCocaine3",
				value = 666,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsWeed1",
				value = 30,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsHeroin1",
				value = 30,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsHeroin2",
				value = 190,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsHeroin3",
				value = 5320,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsKetamine1",
				value = 120,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsKetamine2",
				value = 450,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsKetamine3",
				value = 3360,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsLSD1",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsLSD2",
				value = 750,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsLSD3",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsMeth1",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsMeth2",
				value = 200,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsMeth3",
				value = 1960,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsWeed2",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsGlue1",
				value = 5,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsShrooms1",
				value = 20,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsShrooms2",
				value = 200,
				canBeSold = true
			},
			new Item()
			{
				name = "DrugsGlue2",
				value = 1100,
				canBeSold = true
			},
			#endregion
			#region Security Items
			new Item()
			{
				name = "SecurityUserPass1",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityCodes1",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityCodes2",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityRoutes1",
				value = 1000,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityRoutes2",
				value = 750,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityCodes3",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityUserPass2",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityUserPass3",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityCodes4",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityCodes5",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityLocations1",
				value = 3000,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityCodes6",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityCodes7",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityBadge1",
				value = 1250,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityCodes8",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityUserPass4",
				value = 5000,
				canBeSold = true
			},
			new Item()
			{
				name = "SecurityCodes9",
				value = 1500,
				canBeSold = true
			},
			#endregion
			#region Technology
			new Item()
			{
				name = "TechEReader",
				value = 75,
				canBeSold = true
			},
			new Item()
			{
				name = "TechBrandiFruit1",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "TechBrandiFruit2",
				value = 200,
				canBeSold = true
			},
			new Item()
			{
				name = "TechBrandLifeInvader",
				value = 200,
				canBeSold = true
			},
			new Item()
			{
				name = "TechBrandPanoramic1",
				value = 125,
				canBeSold = true
			},
			new Item()
			{
				name = "TechBrandPanoramic2",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "TechBrandPanoramic3",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "TechCellphone1",
				value = 75,
				canBeSold = true
			},
			new Item()
			{
				name = "TechCellphone2",
				value = 20,
				canBeSold = true
			},
			new Item()
			{
				name = "TechCellphone3",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "TechCellphone4",
				value = 50,
				canBeSold = true
			},
			#endregion
			#region Trash
			new Item()
			{
				name = "TrashReceipt1",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashNewspaper1",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashNewspaper2",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashReceipt2",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashCard1",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashCard2",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab1",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab2",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashCard3",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab3",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashReceipt3",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab4",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashReceipt4",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashLottoTicket",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab5",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab6",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashReceipt5",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab7",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab8",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab9",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab10",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab11",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashCard4",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab12",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab13",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab14",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab15",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashToothbrush",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashReceipt6",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "TrashBarTab16",
				value = 0,
				canBeSold = false
			}
			#endregion
		};

		// Define all of the default food items as localization values
		public static List<Food> defaultFood = new List<Food>()
		{
			#region Snacks & Other Food
			new Food()
			{
				name = "SnackChips1",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackChips2",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackChips3",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackChips4",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackChips5",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackChips6",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackChips7",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackChips8",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackChips9",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackChips10",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackSandwich",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "SnackEnergyDrink1",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackEnergyDrink2",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackEnergyDrink3",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackJuice1",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackJuice2",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCola1",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCola2",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCola3",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCandy1",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCandy2",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackIceCreamBar1",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackIceCreamBar2",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCoffee1",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCoffee2",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCandy3",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCandy4",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCandy5",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCandy6",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackDonut",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "SnackIceCreamBar3",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackCandy7",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "SnackChips11",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "SnackChips12",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "SnackEnergyDrink4",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "SnackCandy8",
				healsPlayer = false,
				healValue = "healNone"
			},
			#endregion
			#region Burger Shot
			new Food()
			{
				name = "BrandBurgerShot1",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandBurgerShot2",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandBurgerShot3",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandBurgerShot4",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "BrandBurgerShot5",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandBurgerShot6",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandBurgerShot7",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandBurgerShot8",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "BrandBurgerShot9",
				healsPlayer = false,
				healValue = "healNone"
			},
			#endregion
			#region Cluckin' Bell
			new Food()
			{
				name = "BrandCluckinBell1",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "BrandCluckinBell2",
				healsPlayer = true,
				healValue = "healLarge"
			},
			new Food()
			{
				name = "BrandCluckinBell3",
				healsPlayer = true,
				healValue = "healMax"
			},
			new Food()
			{
				name = "BrandCluckinBell4",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "BrandCluckinBell5",
				healsPlayer = true,
				healValue = "healSmall"
			},
			#endregion
			#region Silce 'N' Dice
			new Food()
			{
				name = "BrandSliceNDice1",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandSliceNDice2",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandSliceNDice3",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandSliceNDice4",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "BrandSliceNDice5",
				healsPlayer = true,
				healValue = "healMedium"
			},
			#endregion
			#region Taco Bomb
			new Food()
			{
				name = "BrandTacoBomb1",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandTacoBomb2",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandTacoBomb3",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandTacoBomb4",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "BrandTacoBomb5",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "BrandTacoBomb6",
				healsPlayer = true,
				healValue = "healLarge"
			},
			new Food()
			{
				name = "BrandTacoBomb7",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandTacoBomb8",
				healsPlayer = true,
				healValue = "healMax"
			},
			new Food()
			{
				name = "BrandTacoBomb9",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "BrandTacoBomb10",
				healsPlayer = false,
				healValue = "healNone"
			},
			#endregion
			#region Up-n-Atom
			new Food()
			{
				name = "BrandUpNAtom1",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandUpNAtom2",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandUpNAtom3",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "BrandUpNAtom4",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandUpNAtom5",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "BrandUpNAtom6",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "BrandUpNAtom7",
				healsPlayer = false,
				healValue = "healNone"
			},
			#endregion
			#region Other Food Chains
			new Food()
			{
				name = "BrandGeneric1",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandGeneric2",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandGenericBITE1",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandGenericBITE2",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandGenericBITE3",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandGeneric3",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandGeneric4",
				healsPlayer = true,
				healValue = "healLarge"
			},
			new Food()
			{
				name = "BrandGenericHornys1",
				healsPlayer = true,
				healValue = "healLarge"
			},
			new Food()
			{
				name = "BrandGenericHornys2",
				healsPlayer = true,
				healValue = "healSmall"
			},
			new Food()
			{
				name = "BrandGenericHornys3",
				healsPlayer = true,
				healValue = "healLarge"
			},
			new Food()
			{
				name = "BrandGeneric5",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandGenericWigWam1",
				healsPlayer = true,
				healValue = "healLarge"
			},
			new Food()
			{
				name = "BrandGenericWigWam2",
				healsPlayer = true,
				healValue = "healMedium"
			},
			new Food()
			{
				name = "BrandGenericWigWam3",
				healsPlayer = true,
				healValue = "healMedium"
			},
			#endregion
			#region Alcohol
			new Food()
			{
				name = "AlcoholFood1",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "AlcoholFood2",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "AlcoholFood3",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "AlcoholFood4",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "AlcoholFood5",
				healsPlayer = false,
				healValue = "healNone"
			},
			new Food()
			{
				name = "AlcoholFood6",
				healsPlayer = false,
				healValue = "healNone"
			}
			#endregion
		};

		// Define all of the default weapons as localization values
		public static List<Classes.Items.Weapon> defaultWeapons = new List<Classes.Items.Weapon>()
		{
			#region Handguns
			new Classes.Items.Weapon()
			{
				weaponName = "Pistol",
				weaponHash = WeaponHash.Pistol
			},
			#endregion
			#region Shotguns
			new Classes.Items.Weapon()
			{
				weaponName = "SawnOff",
				weaponHash = WeaponHash.SawnOffShotgun
			}
			#endregion
		};

		// Define all of the default pawn shops
		public static List<PawnShop> defaultShops = new List<PawnShop>()
		{
			new PawnShop()
			{
				displayName = "Carson Ave Discount Jewels",
				markerX = 133.185f,
				markerY = -1769.581f,
				markerZ = 29.409f
			},
			new PawnShop()
			{
				displayName = "Del Perro Pawn & Jewelry",
				markerX = -1459.451f,
				markerY = -414.505f,
				markerZ = 35.714f
			},
			new PawnShop()
			{
				displayName = "F.T. Pawn",
				markerX = 412.780243f,
				markerY = 313.337982f,
				markerZ = 103.020088f
			},
			new PawnShop()
			{
				displayName = "Senora Fwy Discount Jewels",
				markerX = 2661.764f,
				markerY = 3466.93921f,
				markerZ = 55.80189f
			},
			new PawnShop()
			{
				displayName = "Strawberry Pawn & Jewelery",
				markerX = 183.448f,
				markerY = -1319.98f,
				markerZ = 29.322f
			}
		};

		// Define all of the blocked classes and default model exceptions
		public static List<BlockedClass> defaultBlockedClasses = new List<BlockedClass>()
		{
			new BlockedClass()
			{
				className = "Boats",
				modelExceptions = new List<string> {"marquis"}
			},
			new BlockedClass()
			{
				className = "Cycles",
				modelExceptions = new List<string> {}
			},
			new BlockedClass()
			{
				className = "Helicopters",
				modelExceptions = new List<string> {"supervolito", "supervolito2", "swift", "swift2", "volatus"}
			},
			new BlockedClass()
			{
				className = "Military",
				modelExceptions = new List<string> {"barracks", "barracks2", "barracks3", "barrage", "crusader", "vetir"}
			},
			new BlockedClass()
			{
				className = "Motorcycles",
				modelExceptions = new List<string> {}
			},
			new BlockedClass()
			{
				className = "OpenWheel",
				modelExceptions = new List<string> {}
			},
			new BlockedClass()
			{
				className = "Planes",
				modelExceptions = new List<string> {"jet", "luxor", "luxor2", "miljet", "nimbus", "shamal"}
			},
			new BlockedClass()
			{
				className = "Trains",
				modelExceptions = new List<string> {}
			},
			new BlockedClass()
			{
				className = "Utility",
				modelExceptions = new List<string> {"sadler", "sadler2", "scrap", "towtruck", "towtruck2", "utillitruck", "utillitruck2", "utillitruck3", "slamtruck"}
			}
		};
	}
}
