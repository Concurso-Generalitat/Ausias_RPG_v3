using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	/*
	 * Usable items:
	 * camera
	 * campana 1
	 * campana 2
	 * campana 3
	 * pendulo
	 * pegamento
	 * caña
	 * pez
	 * pagina 1
	 * pagina 2
	 * pagina 3
	 * pagina 4
	 * 
	 */

	private GameObject objSceneManager;

	void Start ()
	{
		objSceneManager = GameObject.Find ("SceneManager");
	}
	
	// Update is called once per frame
	void Update ()
	{
		Game_Data data = objSceneManager.GetComponent<Game_Data> ();

		for (int i = 0; i < data.MAX_ITEMS; i++)
		{
			if(data.objectList[i] != InventoryItems.NADA)
			{
				//GameObject.Find("Image0").GetComponent<I
			}
		}
	
	}
}
