using UnityEngine;
using System.Collections;

public class Game_Data
{
	public int act;
	public int progress;
	public int last_scene;
	public InventoryItems[] objectList;

	public int MAX_ITEMS;
	
	public Game_Data()
	{
		act = progress = last_scene = 0;
		
		MAX_ITEMS = 6;

		objectList = new InventoryItems[MAX_ITEMS];


		for (int i = 0; i < MAX_ITEMS; i++)
		{
			objectList[i] = InventoryItems.NADA;
		}
	}
	
	public void Reset()
	{
		act = progress = last_scene = 0;
		
		for (int i = 0; i < MAX_ITEMS; i++)
		{
			objectList[i] = InventoryItems.NADA;
		}
	}
	
	public override string ToString()
	{
		string returnValue = "Acto: " + act + "; Progress: " + progress + "; Last Scene: " + last_scene + "\nItems: ";
		
		for (int i = 0; i < MAX_ITEMS; i++)
		{
			returnValue += ItemString(objectList[i]) + ", ";
		}
		
		return returnValue;
	}


	public bool Collect(InventoryItems id, int progressModifier)
	{
		for (int i = 0; i < MAX_ITEMS; i++)
		{
			if (objectList[i] == InventoryItems.NADA)
			{
				objectList[i] = id;
				progress += progressModifier;

				return true;
			}
		}

		return false;
	}









	
	
	public string ItemString(InventoryItems item)
	{
		switch(item)
		{
		case InventoryItems.NADA:       return "Nada";
		case InventoryItems.CAMARA:     return "CAMARA";
		case InventoryItems.DINERO:     return "DINERO";
		case InventoryItems.TRIPODE:    return "TRIPODE";
		case InventoryItems.CARRETE:    return "CARRETE";
		case InventoryItems.PENDULO:    return "PENDULO";
		case InventoryItems.CAMPANA_1:  return "CAMPANA_1";
		case InventoryItems.CAMPANA_2:  return "CAMPANA_2";
		case InventoryItems.CAMPANA_3:  return "CAMPANA_3";
		case InventoryItems.CAMPANA_4:  return "CAMPANA_4";
		case InventoryItems.ESCALERAS:  return "ESCALERAS";
		case InventoryItems.SOMBRERO:   return "SOMBRERO";
		case InventoryItems.PEGAMENTO:  return "PEGAMENTO";
		case InventoryItems.PALO:       return "PALO";
		case InventoryItems.GUSANOS:    return "GUSANOS";
		case InventoryItems.ANZUELO:    return "ANZUELO";
		case InventoryItems.CANA:       return "CAÑA";
		case InventoryItems.MECHERO_1:  return "MECHERO_1";
		case InventoryItems.MECHERO_2:  return "MECHERO_2";
		case InventoryItems.ACEITE:     return "ACEITE";
		case InventoryItems.GANZUAS:    return "GANZUAS";
		case InventoryItems.PAGINA_1:   return "PAGINA_1";
		case InventoryItems.PAGINA_2:   return "PAGINA_2";
		case InventoryItems.PAGINA_3:   return "PAGINA_3";
		case InventoryItems.PAGINA_4:   return "PAGINA_4";
		default:                        return " ";
		}
	}

	public string ItemNumString(InventoryItems item)
	{
		switch(item)
		{
		case InventoryItems.NADA:       return "00";
		case InventoryItems.CAMARA:     return "01";
		case InventoryItems.DINERO:     return "02";
		case InventoryItems.TRIPODE:    return "03";
		case InventoryItems.CARRETE:    return "04";
		case InventoryItems.PENDULO:    return "05";
		case InventoryItems.CAMPANA_1:  return "06";
		case InventoryItems.CAMPANA_2:  return "07";
		case InventoryItems.CAMPANA_3:  return "08";
		case InventoryItems.CAMPANA_4:  return "09";
		case InventoryItems.ESCALERAS:  return "10";
		case InventoryItems.SOMBRERO:   return "11";
		case InventoryItems.PEGAMENTO:  return "12";
		case InventoryItems.PALO:       return "13";
		case InventoryItems.GUSANOS:    return "14";
		case InventoryItems.ANZUELO:    return "15";
		case InventoryItems.CANA:       return "16";
		case InventoryItems.MECHERO_1:  return "17";
		case InventoryItems.MECHERO_2:  return "18";
		case InventoryItems.ACEITE:     return "19";
		case InventoryItems.GANZUAS:    return "20";
		case InventoryItems.PAGINA_1:   return "21";
		case InventoryItems.PAGINA_2:   return "22";
		case InventoryItems.PAGINA_3:   return "23";
		case InventoryItems.PAGINA_4:   return "24";
		default:                        return "-1";
		}
	}

	public InventoryItems ItemFromStr(string item)
	{
		switch(item)
		{
		case "00": return InventoryItems.NADA;
		case "01": return InventoryItems.CAMARA;
		case "02": return InventoryItems.DINERO;
		case "03": return InventoryItems.TRIPODE;
		case "04": return InventoryItems.CARRETE;
		case "05": return InventoryItems.PENDULO;
		case "06": return InventoryItems.CAMPANA_1;
		case "07": return InventoryItems.CAMPANA_2;
		case "08": return InventoryItems.CAMPANA_3;
		case "09": return InventoryItems.CAMPANA_4;
		case "10": return InventoryItems.ESCALERAS;
		case "11": return InventoryItems.SOMBRERO;
		case "12": return InventoryItems.PEGAMENTO;
		case "13": return InventoryItems.PALO;
		case "14": return InventoryItems.GUSANOS;
		case "15": return InventoryItems.ANZUELO;
		case "16": return InventoryItems.CANA;
		case "17": return InventoryItems.MECHERO_1;
		case "18": return InventoryItems.MECHERO_2;
		case "19": return InventoryItems.ACEITE;
		case "20": return InventoryItems.GANZUAS;
		case "21": return InventoryItems.PAGINA_1;
		case "22": return InventoryItems.PAGINA_2;
		case "23": return InventoryItems.PAGINA_3;
		case "24": return InventoryItems.PAGINA_4;
		default:   return InventoryItems.NADA;
		}
	}
}




























