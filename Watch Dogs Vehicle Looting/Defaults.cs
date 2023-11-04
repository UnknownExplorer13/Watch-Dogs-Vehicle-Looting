using System.Collections.Generic;
using Watch_Dogs_Vehicle_Looting.Classes.Items;
using GTA.Native;
using Watch_Dogs_Vehicle_Looting.Classes;

namespace Watch_Dogs_Vehicle_Looting
{
	public class Defaults
	{
		// Define all of the default pawn items
		public static List<Item> defaultItems = new List<Item>()
		{
			new Item()
			{
				name = "Kronos Timepiece",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "iFruit 9iX",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "Silver Ring",
				value = 250,
				canBeSold = true
			},
			new Item()
			{
				name = "Gold Ring",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "Panoramic Winblows 98 Tablet",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "Kronox Watch",
				value = 125,
				canBeSold = true
			},
			new Item()
			{
				name = "E-Reader",
				value = 75,
				canBeSold = true
			},
			new Item()
			{
				name = "Silver Artisan Ring",
				value = 75,
				canBeSold = true
			},
			new Item()
			{
				name = "IFruit Tablet",
				value = 200,
				canBeSold = true
			},
			new Item()
			{
				name = "IFruit Smart Watch",
				value = 300,
				canBeSold = true
			},
			new Item()
			{
				name = "Antique Coin",
				value = 125,
				canBeSold = true
			},
			new Item()
			{
				name = "LifeInvader II Microcomputer",
				value = 200,
				canBeSold = true
			},
			new Item()
			{
				name = "Panoramic Fitness Wristband",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "Panoramic Smartphone",
				value = 125,
				canBeSold = true
			},
			new Item()
			{
				name = "BackSide SkateBoard",
				value = 135,
				canBeSold = true
			},
			new Item()
			{
				name = "Can of CoolHand Lube Motor-Oil",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "Bottle of Costa Del Perro",
				value = 300,
				canBeSold = true
			},
			new Item()
			{
				name = "Bottle of Bleuter'd Champagne",
				value = 750,
				canBeSold = true
			},
			new Item()
			{
				name = "Bottle of Bourgeoix Cognag",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "Daily Globe Newspaper",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Daily Rag Newspaper",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Hi-Men Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Pitchers Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Las Cuadras Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Limey's Juice and Smoothies Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Mirror Park Tavern Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Out of Towners Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Pipeline Inn Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Shenanigan's Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Singleton's Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "The Lust Resort Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "The Hen House Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Hookies Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Mojito Inn Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "The Bay Bar Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Yellow Jack Inn Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Pack of Cardiaque Cigarettes",
				value = 7,
				canBeSold = true
			},
			new Item()
			{
				name = "Bottle of Cardiaque Brandy",
				value = 25,
				canBeSold = true
			},
			new Item()
			{
				name = "Adios Airlines Ticket",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "Air Herler Airline Ticket",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "Caipira Airways Ticket",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "Air Emu Ticket",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "MyFly Airlines Ticket",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "FlyUS Airlines Ticket",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "Private Charter Airline Ticket",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "Amputeens Magazine Issue #8 Summer Special",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "This Months Hottest XXX Mag",
				value = 10,
				canBeSold = true
			},
			new Item()
			{
				name = "Goldberg Ligner & Shyster Lawfirm Card",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Bottle of Ampheterate",
				value = 75,
				canBeSold = true
			},
			new Item()
			{
				name = "Box of 14mg Alco-Patch",
				value = 250,
				canBeSold = true
			},
			new Item()
			{
				name = "Bottle of Culmanex",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "Box of 15mg Delladamol",
				value = 300,
				canBeSold = true
			},
			new Item()
			{
				name = "Box of Lax to the Max",
				value = 5,
				canBeSold = true
			},
			new Item()
			{
				name = "Box of 50mg Mollis",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "Box of 50mg Mulis",
				value = 500,
				canBeSold = true
			},
			new Item()
			{
				name = "Bottle of 100mg Paraliz",
				value = 1000,
				canBeSold = true
			},
			new Item()
			{
				name = "Box of CJ's JIZZ!",
				value = 5,
				canBeSold = true
			},
			new Item()
			{
				name = "Tube of CJ's Toothpaste",
				value = 3,
				canBeSold = true
			},
			new Item()
			{
				name = "Used Toothbrush",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Ammu-Nation Receipt",
				value = 1,
				canBeSold = true
			},
			new Item()
			{
				name = "Los Santos Customs Receipt",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Bottle of NOGO Vodka",
				value = 10,
				canBeSold = true
			},
			new Item()
			{
				name = "Fleeca Credit Card",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "Shark Credit Card",
				value = 5,
				canBeSold = true
			},
			new Item()
			{
				name = "Limit Credit Card",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "Bottle of Tequilya Tequila",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "Bottle of The Mount Whiskey",
				value = 25,
				canBeSold = true
			},
			new Item()
			{
				name = "Vangelico Receipt",
				value = 1,
				canBeSold = true
			},
			new Item()
			{
				name = "Gruppe Sechs Security Codes",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "Gruppe Sechs Van Routes",
				value = 1000,
				canBeSold = true
			},
			new Item()
			{
				name = "Doctor Kush 1/8th of Northern Lights",
				value = 30,
				canBeSold = true
			},
			new Item()
			{
				name = "Hammerstein & Faust Lawfirm Card",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Humane Labs Security Codes",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "Humane Labs Delivery Routes",
				value = 750,
				canBeSold = true
			},
			new Item()
			{
				name = "Fat Losers Liposuction Receipt",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Fleeca Bank Security Codes",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "J's Bonds Business Card",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Merryweather Security Codes",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "Merryweather OP Locations",
				value = 3000,
				canBeSold = true
			},
			new Item()
			{
				name = "Maze Bank Security Codes",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "Mile High Organics 1oz of Purple Haze",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "Mors Mutual Insurance Papers",
				value = 20,
				canBeSold = true
			},
			new Item()
			{
				name = "Laundromat Receipts",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "LCN Username & Password",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "BAWSAQ Username & Password",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "LifeInvader Username & Password",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "Stolen LifeInvader Usernames & Passwords",
				value = 5000,
				canBeSold = true
			},
			new Item()
			{
				name = "National Transfer & Storage Co. Receipt",
				value = 1,
				canBeSold = true
			},
			new Item()
			{
				name = "Los Santos Golf Club Membership Card",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "Pacific Allied Shipyard Security Badge",
				value = 1250,
				canBeSold = true
			},
			new Item()
			{
				name = "LSPD Auto Impound Gate Code",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "Pre-Paid Los Santos Traffic Card",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "Peckerwood T-Shirt",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "Losing San Andreas Lotto Ticket",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "1g SeaGrass Herbals Gorilla Glue #9",
				value = 5,
				canBeSold = true
			},
			new Item()
			{
				name = "Premium Deluxe Motorsports Bill of Sale",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "Slaughter Slaughter & Slaughter Lawfirm Card",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Glass Pipe From Smokers Emporium",
				value = 10,
				canBeSold = true
			},
			new Item()
			{
				name = "Smoke on the Water 1 Pound Citral Glue",
				value = 1100,
				canBeSold = true
			},
			new Item()
			{
				name = "Carton of Redwoods",
				value = 65,
				canBeSold = true
			},
			new Item()
			{
				name = "Tequi-la-la Bar Tab",
				value = 0,
				canBeSold = false
			},
			new Item()
			{
				name = "Total Bankers Security Codes",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "Schlongberg Sachs Security Codes",
				value = 1500,
				canBeSold = true
			},
			new Item()
			{
				name = "Bottle of U Lube It Oil Additive",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "Bottle of U Lube It Injection Cleaner",
				value = 10,
				canBeSold = true
			},
			new Item()
			{
				name = "Old Union Deposity Security Codes",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "Pre-Paid Whiz Cellphone",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "Pre-Paid Badger Cellphone",
				value = 75,
				canBeSold = true
			},
			new Item()
			{
				name = "Pre-Paid Panoramic Cellphone",
				value = 50,
				canBeSold = true
			},
			new Item()
			{
				name = "Panoramic Tablet",
				value = 150,
				canBeSold = true
			},
			new Item()
			{
				name = "Pre-Paid BitterSweet Cellphone",
				value = 20,
				canBeSold = true
			},
			new Item()
			{
				name = "IFruit Shoes",
				value = 750,
				canBeSold = true
			},
			new Item()
			{
				name = "Pack of Redwood Cigarettes",
				value = 5,
				canBeSold = true
			},
			new Item()
			{
				name = "Carton of Cardiaque Cigarettes",
				value = 75,
				canBeSold = true
			},
			new Item()
			{
				name = "0.1g of Heroin",
				value = 30,
				canBeSold = true
			},
			new Item()
			{
				name = "1g of Heroin",
				value = 190,
				canBeSold = true
			},
			new Item()
			{
				name = "1Oz of Heroin",
				value = 5320,
				canBeSold = true
			},
			new Item()
			{
				name = "0.25g of Meth",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "Eight Ball 3.5g of Meth",
				value = 200,
				canBeSold = true
			},
			new Item()
			{
				name = "1Oz of Meth",
				value = 1960,
				canBeSold = true
			},
			new Item()
			{
				name = "1g of Cocaine",
				value = 120,
				canBeSold = true
			},
			new Item()
			{
				name = "3.5g of Cocaine",
				value = 450,
				canBeSold = true
			},
			new Item()
			{
				name = "1Oz of Cocaine",
				value = 3360,
				canBeSold = true
			},
			new Item()
			{
				name = "1g of Crack Cocaine",
				value = 120,
				canBeSold = true
			},
			new Item()
			{
				name = "3.5g of Crack Cocaine",
				value = 450,
				canBeSold = true
			},
			new Item()
			{
				name = "1Oz of Crack Cocaine",
				value = 666,
				canBeSold = true
			},
			new Item()
			{
				name = "1 MDMA Pill",
				value = 20,
				canBeSold = true
			},
			new Item()
			{
				name = "2 MDMA Pills",
				value = 40,
				canBeSold = true
			},
			new Item()
			{
				name = "3 MDMA Pills",
				value = 60,
				canBeSold = true
			},
			new Item()
			{
				name = "1g of Ketamine",
				value = 120,
				canBeSold = true
			},
			new Item()
			{
				name = "3.5g of Ketamine",
				value = 450,
				canBeSold = true
			},
			new Item()
			{
				name = "1Oz of Ketamine",
				value = 3360,
				canBeSold = true
			},
			new Item()
			{
				name = "1g of Crack Cocaine",
				value = 120,
				canBeSold = true
			},
			new Item()
			{
				name = "3.5g of Crack Cocaine",
				value = 450,
				canBeSold = true
			},
			new Item()
			{
				name = "1Oz of Crack Cocaine",
				value = 666,
				canBeSold = true
			},
			new Item()
			{
				name = "1/8th of Shrooms",
				value = 20,
				canBeSold = true
			},
			new Item()
			{
				name = "1Oz of Shrooms",
				value = 200,
				canBeSold = true
			},
			new Item()
			{
				name = "1 Tab of LSD",
				value = 15,
				canBeSold = true
			},
			new Item()
			{
				name = "Half Sheet of LSD",
				value = 750,
				canBeSold = true
			},
			new Item()
			{
				name = "Full Sheet of LSD",
				value = 1500,
				canBeSold = true
			}
		};

		// Define all of the default food items
		public static List<Food> defaultFood = new List<Food>()
		{
			new Food()
			{
				name = "Burger Shot Bleeder Burger",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bologna Sandwich",
				healsPlayer = true
			},
			new Food()
			{
				name = "EgoChaser",
				healsPlayer = true
			},
			new Food()
			{
				name = "Metorite Bar",
				healsPlayer = true
			},
			new Food()
			{
				name = "P's & Q's",
				healsPlayer = true
			},
			new Food()
			{
				name = "Candybox Chocolate Bar",
				healsPlayer = true
			},
			new Food()
			{
				name = "Can of Junk Energy",
				healsPlayer = false
			},
			new Food()
			{
				name = "Rusty Brown Donut",
				healsPlayer = true
			},
			new Food()
			{
				name = "Can of Sprunk",
				healsPlayer = true
			},
			new Food()
			{
				name = "Can of E-Cola",
				healsPlayer = true
			},
			new Food()
			{
				name = "Slice of Pizza This... Pizza",
				healsPlayer = true
			},
			new Food()
			{
				name = "Zebra Bar",
				healsPlayer = true
			},
			new Food()
			{
				name = "Captain's Log Sno-Caps",
				healsPlayer = true
			},
			new Food()
			{
				name = "EarthQuakes Crunch Bar",
				healsPlayer = true
			},
			new Food()
			{
				name = "Release Gum",
				healsPlayer = false
			},
			new Food()
			{
				name = "Uder Milken Ice-Cream Bar",
				healsPlayer = true
			},
			new Food()
			{
				name = "Can of Orang-O-Tang",
				healsPlayer = true
			},
			new Food()
			{
				name = "Box of Orange Love Juice",
				healsPlayer = true
			},
			new Food()
			{
				name = "Box of Apple Love Juice",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bottle of Arctic Douche Electrolyte",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bottle of Icicle Fire Electrolyte",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bottle of Yellow Snow Electrolyte",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Big Cheese Phat Chips",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Salt & Sauce Phat Chips",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Sticky Ribs Phat Chips",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Super Salt Phat Chips",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Habanero Phat Chips",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Paprika Phat Chips",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Radical Sour Cream & Black Liquorice Quinoa Phat Chips",
				healsPlayer = false
			},
			new Food()
			{
				name = "Bag of Funky Honey Mustard Greens & Ketchup Prawns Phat Chips",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Chipotle Wheatgrass Phat Chips",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Bavarian Car Key Party Phat Chips",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Dry Greek Rub Greens Phat Chips",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bag of Norwegian Salmon Rancher Surprise Phat Chips",
				healsPlayer = false
			},
			new Food()
			{
				name = "Cup of Bean Machine Coffee",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bishop's Chicken Chicken Sandwhich",
				healsPlayer = true
			},
			new Food()
			{
				name = "BITE! Sub-Sandwhich",
				healsPlayer = true
			},
			new Food()
			{
				name = "BITE! Wrap",
				healsPlayer = true
			},
			new Food()
			{
				name = "BITE! Salad",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bottle of Blarney's Stout Beer",
				healsPlayer = false
			},
			new Food()
			{
				name = "Burger Shot MoneyShot Burger",
				healsPlayer = true
			},
			new Food()
			{
				name = "Burger Shot Torpedo Burger",
				healsPlayer = true
			},
			new Food()
			{
				name = "Burger Shot Meat-Free Burger",
				healsPlayer = true
			},
			new Food()
			{
				name = "Burger Shot Meat-Shake",
				healsPlayer = false
			},
			new Food()
			{
				name = "Burger Shot Pork-Hole Burger",
				healsPlayer = true
			},
			new Food()
			{
				name = "Burger Shot Meat-Shavings Burger",
				healsPlayer = true
			},
			new Food()
			{
				name = "Burger Shot Heart-Stopper Burger",
				healsPlayer = false
			},
			new Food()
			{
				name = "Cluckin' Little Meal",
				healsPlayer = true
			},
			new Food()
			{
				name = "Cluckin' Big Meal",
				healsPlayer = true
			},
			new Food()
			{
				name = "Cluckin' Huge Meal",
				healsPlayer = true
			},
			new Food()
			{
				name = "Cluckin' Salad Meal",
				healsPlayer = true
			},
			new Food()
			{
				name = "Attack-A-Taco Taco",
				healsPlayer = true
			},
			new Food()
			{
				name = "Chihuahua Hotdog",
				healsPlayer = true
			},
			new Food()
			{
				name = "Cup of Hit 'N' Run Coffee",
				healsPlayer = true
			},
			new Food()
			{
				name = "Horny's Burger Meal",
				healsPlayer = true
			},
			new Food()
			{
				name = "Horny's Taco Meal",
				healsPlayer = true
			},
			new Food()
			{
				name = "Horny's HashBrowns",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bottle of Dusche Beer",
				healsPlayer = false
			},
			new Food()
			{
				name = "Famous Hamburgers Hamburger Meal",
				healsPlayer = true
			},
			new Food()
			{
				name = "Bottle of Jakey's Lager",
				healsPlayer = false
			},
			new Food()
			{
				name = "Bottle of Logger Beer",
				healsPlayer = false
			},
			new Food()
			{
				name = "Bottle of Patriot Beer",
				healsPlayer = false
			},
			new Food()
			{
				name = "Bottle of Piswasser",
				healsPlayer = false
			},
			new Food()
			{
				name = "Slice of Slice 'N' Dice Pizza",
				healsPlayer = true
			},
			new Food()
			{
				name = "Slice 'N' Dice Burger",
				healsPlayer = true
			},
			new Food()
			{
				name = "Slice 'N' Dice Hotdog",
				healsPlayer = true
			},
			new Food()
			{
				name = "Slice 'N' Dice Donut",
				healsPlayer = true
			},
			new Food()
			{
				name = "Slice 'N' Dice Milkshake",
				healsPlayer = true
			},
			new Food()
			{
				name = "Burger Shot Milkshake",
				healsPlayer = true
			},
			new Food()
			{
				name = "Cluckin' Bell Milkshake",
				healsPlayer = true
			},
			new Food()
			{
				name = "Up-n-Atom Triple Burger",
				healsPlayer = true
			},
			new Food()
			{
				name = "Up-n-Atom Extra Creamy Jumbo Shake",
				healsPlayer = false
			},
			new Food()
			{
				name = "Taco Bomb El Matador Verde Breakfast Burrito",
				healsPlayer = true
			},
			new Food()
			{
				name = "Taco Bomb Hot Mess Deep Fried Salad",
				healsPlayer = true
			},
			new Food()
			{
				name = "Taco Bomb 2lb Foaming Beef-ish Bazooka",
				healsPlayer = false
			},
			new Food()
			{
				name = "Taco Bomb Chimichingado Chiquito",
				healsPlayer = false
			},
			new Food()
			{
				name = "Taco Bomb Cheesy Meat Flappers",
				healsPlayer = true
			},
			new Food()
			{
				name = "Taco Bomb Volcanic Mudsplatter Nachos",
				healsPlayer = true
			},
			new Food()
			{
				name = "Taco Bomb Paco the Taco's Lil' Gringo Meal",
				healsPlayer = true
			},
			new Food()
			{
				name = "Taco Libre Punto Grande Meal",
				healsPlayer = true
			},
			new Food()
			{
				name = "Taco Libre Luchadore Huevos Breakfast Burrito",
				healsPlayer = true
			},
			new Food()
			{
				name = "Cherry Popper Chocolate Chunk Ice-Cream Bar",
				healsPlayer = true
			},
			new Food()
			{
				name = "Cherry Popper Raspberry Ripple Ice-Cream Bar",
				healsPlayer = true
			},
			new Food()
			{
				name = "Taco Farmer Combo Meal",
				healsPlayer = true
			},
			new Food()
			{
				name = "WigWam Burger 20pc Chicken Nugget",
				healsPlayer = true
			},
			new Food()
			{
				name = "WigWam Burger Geronimo Wings",
				healsPlayer = true
			},
			new Food()
			{
				name = "WigWam Burger Rings of Fire",
				healsPlayer = true
			},
			new Food()
			{
				name = "Up-n-Atom Bacon-Triple Cheese Melt",
				healsPlayer = false
			},
			new Food()
			{
				name = "Up-n-Atom Footlong Chili-Dog",
				healsPlayer = true
			},
			new Food()
			{
				name = "Up-n-Atom French Fries",
				healsPlayer = true
			},
			new Food()
			{
				name = "Up-n-Atom Chicken Liver Surprise",
				healsPlayer = true
			},
			new Food()
			{
				name = "Up-n-Atom Triple Burger Meal",
				healsPlayer = false
			}
		};

		// Define all of the default weapons
		public static List<Weapon> defaultWeapons = new List<Weapon>()
		{
			new Weapon()
			{
				weaponName = "Pistol",
				weaponHash = WeaponHash.Pistol
			},
			new Weapon()
			{
				weaponName = "Sawn-Off Shotgun",
				weaponHash = WeaponHash.SawnOffShotgun
			}
		};

		// Define all of the default pawn shops
		public static List<PawnShop> defaultShops = new List<PawnShop>()
		{
			new PawnShop()
			{
				displayName = "Del Perro Pawn & Jewelry",
				markerX = -1459.451f,
				markerY = -414.505f,
				markerZ = 35.714f
			},
			new PawnShop()
			{
				displayName = "Strawberry Pawn & Jewelery",
				markerX = 183.448f,
				markerY = -1319.98f,
				markerZ = 29.322f
			},
			new PawnShop()
			{
				displayName = "Carson Ave Discount Jewels",
				markerX = 133.185f,
				markerY = -1769.581f,
				markerZ = 29.409f
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
			}
		};

		// Define all of the default blocked classes and model exceptions
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
