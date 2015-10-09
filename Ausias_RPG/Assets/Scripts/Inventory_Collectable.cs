using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Inventory_Collectable : MonoBehaviour
{
	private Transform ausias;

	public GameObject message;
	private Text text;

	public InventoryItems id = InventoryItems.CAMARA;
	public int closeDistance = 2;
	public int ProgressModifier = 0;

	private GameObject ObjSceneManager;

	// Use this for initialization
	void Start () {
		text = message.GetComponentInChildren<Text> ();
		ObjSceneManager = GameObject.Find("SceneManager");
		text.text = ObjSceneManager.GetComponent<SceneManager> ().gameData.ItemString (id);
	}
	
	// Update is called once per frame
	void Update ()
	{

		// check if character is close enough
		if (ausias)
		{
			Vector3 offset = ausias.position - transform.position;
			if (offset.sqrMagnitude < closeDistance * closeDistance)
			{
				message.SetActive(true);

				if (Input.GetKeyUp (KeyCode.F))
				{
					ObjSceneManager.GetComponent<SceneManager> ().gameData.Collect(id, ProgressModifier);

					this.gameObject.SetActive (false);
				}
			}
			else
			{
				message.SetActive (false);
			}
			
		}

	}
}
