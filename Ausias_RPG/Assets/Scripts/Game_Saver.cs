using UnityEngine;
using System.Collections;

using System;
using System.IO;

public class Game_Saver
{
	private int current_slot;

	private string GAME_SLOT_PATH;
	private StreamReader reader;

	public Game_Saver(string path)
	{
		GAME_SLOT_PATH = path;
		current_slot = 0;
	}

	public Game_Data GetSavedData(int index)
	{
		Game_Data retValue = new Game_Data();

		reader = new StreamReader (GAME_SLOT_PATH);

		string tmp = "";
		string token = "";

		int x = 0;

		for (int i = 0; i < index; i++)
		{
			tmp = reader.ReadLine ();
		}

		if(tmp[0] != '0')
		{
			//-----ACTO---------------------------------------
			token = "" + tmp[0];
			
			if (!Int32.TryParse(token, out x)) { x = ParseBrute1(token); }
			
			retValue.act = x;
			
			//-----PROGRESO-----------------------------------
			token = "" + tmp[2] + tmp[3];
			
			if (!Int32.TryParse(token, out x)){ x = ParseBrute2(token); }
			
			retValue.progress = x;
			
			//-----LAST SCENE---------------------------------
			token = "" + tmp[5];
			
			if (!Int32.TryParse(token, out x)){ x = ParseBrute1("" + tmp[5]); }
			
			retValue.last_scene = x;
			
			//-----ITEMS--------------------------------------
			for(int j = 7; j < 23; j+=3)//7, 10, 13, 16, 19, 22
			{
				token = "" + tmp[(3*j) + 7] + tmp[(3*j) + 8];
				
				retValue.objectList[j] = retValue.ItemFromStr(token);
			}
		}

		reader.Close ();

		Debug.Log (retValue);

		return retValue;
	}

	public Game_Data[] GetAllSavedData()
	{
		Game_Data[] retValue = { new Game_Data(), new Game_Data(), new Game_Data() };
		
		reader = new StreamReader (GAME_SLOT_PATH);
		
		String tmp, token;

		int x = 0;
		
		for (int i = 0; i < 3; i++)
		{
			tmp = reader.ReadLine ();

			if(tmp[0] != '0') //implies GameSlot is not empty
			{
				//-----ACTO---------------------------------------
				token = "" + tmp[0];

				if (!Int32.TryParse(token, out x)) { x = ParseBrute1(token); }

				retValue[i].act = x;

				//-----PROGRESO-----------------------------------
				token = "" + tmp[2] + tmp[3];

				if (!Int32.TryParse(token, out x)){ x = ParseBrute2(token); }

				retValue[i].progress = x;

				//-----LAST SCENE---------------------------------
				token = "" + tmp[5];
				
				if (!Int32.TryParse(token, out x)){ x = ParseBrute1("" + tmp[5]); }

				retValue[i].last_scene = x;

				//-----ITEMS--------------------------------------
				for(int j = 7; j < 23; j+=3)//7, 10, 13, 16, 19, 22
				{
					token = "" + tmp[(3*j) + 7] + tmp[(3*j) + 8];

					retValue[i].objectList[j] = retValue[i].ItemFromStr(token);
				}
			}
		}
		
		reader.Close ();

		for (int i = 1; i < 3; i++)
		{
			Debug.Log (retValue[i]);
		}
		
		return retValue;
	}

	public void SaveProgress(Game_Data data)
	{
		string tmp;
		string[] lines = {"", "", ""};

		reader = new StreamReader (GAME_SLOT_PATH);

		for(int i = 0; i < 3; i++)
		{
			lines[i] = reader.ReadLine();

			if(current_slot + 1 == i)
			{
				tmp = data.act + ":";

				if(data.progress < 10) tmp += "0";

				tmp += data.progress + ":" + data.last_scene + ":";

				for (int j = 0; j < data.MAX_ITEMS - 1; j++)
				{
					tmp += data.ItemNumString(data.objectList[i]) + ",";
				}

				tmp += data.ItemNumString(data.objectList[data.MAX_ITEMS - 1]);

				lines[i] = tmp;
			}
		}

		System.IO.File.WriteAllLines(GAME_SLOT_PATH, lines);
	}


	private int ParseBrute1(string num)
	{
		switch (num)
		{
		case "0": return  0;
		case "1": return  1;
		case "2": return  2;
		case "3": return  3;
		case "4": return  4;
		case "5": return  5;
		case "6": return  6;
		case "7": return  7;
		case "8": return  8;
		case "9": return  9;
		default:  return -1;
		}
	}

	private int ParseBrute2(string num)
	{
		switch (num)
		{
		case  "0": return   0;
		case  "1": return   1;
		case  "2": return   2;
		case  "3": return   3;
		case  "4": return   4;
		case  "5": return   5;
		case  "6": return   6;
		case  "7": return   7;
		case  "8": return   8;
		case  "9": return   9;
		case "10": return  10;
		case "11": return  11;
		case "12": return  12;
		case "13": return  13;
		case "14": return  14;
		case "15": return  15;
		case "16": return  16;
		case "17": return  17;
		case "18": return  18;
		case "19": return  19;
		case "20": return  20;
		case "21": return  21;
		case "22": return  22;
		case "23": return  23;
		case "24": return  24;
		case "25": return  25;
		default:   return  -1;
		}
	}

}




























