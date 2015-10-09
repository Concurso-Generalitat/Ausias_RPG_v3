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
					GameObject.Find("SceneManager").GetComponent<SceneManager> ().gameData.Collect(id, ProgressModifier);
					this.GetComponent<AudioSource>().Play();
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
