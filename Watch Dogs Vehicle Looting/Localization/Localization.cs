using GTA;
using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Watch_Dogs_Vehicle_Looting.Localization
{
	public class Localize
	{
		// C# implementation of function with same name from Premium Deluxe Motorsport Car Dealership by I'm Not MentaL
		// https://github.com/qiangqiang101/PremiumDeluxeMotorsport.NET/blob/master/PremiumDeluxeMotorsportCarDealership3/Class/CFGRead.vb
		public static string ReadCfgValue(string key, string file)
		{
			string[] lines = System.IO.File.ReadAllLines(file);
			string temp = null;
			string val = null;

			foreach (string l in lines)
			{
				if (l.StartsWith(key))
				{
					temp = l.Substring(key.Length + 1);
					val = temp.Replace(((char) 34).ToString(), "");
					break;
				}
			}

			return val;
		}

		// C# implementation of function with same name from Premium Deluxe Motorsport Car Dealership by I'm Not MentaL
		// https://github.com/qiangqiang101/PremiumDeluxeMotorsport.NET/blob/master/PremiumDeluxeMotorsportCarDealership3/Class/Helper.vb
		public static string GetLangEntry(string Lang)
		{
			string result = ReadCfgValue(Lang, Application.StartupPath + "\\scripts\\Watch Dogs Vehicle Looting\\Translations\\" + Game.Language.ToString() + ".cfg");
			string real_result = null;
			if (result == null)
				real_result = "NULL";
			else
				real_result = result;

			return real_result;
		}
	}
}
