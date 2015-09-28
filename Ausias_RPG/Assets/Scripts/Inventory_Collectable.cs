using UnityEngine;
using System.Collections;

public class Inventory_Collectable : MonoBehaviour
{

	public Transform other;
	public float closeDistance = 1.5F;
	public InventoryItems id = InventoryItems.NADA;


	// Use this for initialization
	void Start () {
		// find character in scene

		// find scene manager in scene

	
	}
	
	// Update is called once per frame
	void Update ()
	{
		// check if character is close enough
		if (other) {
			Vector3 offset = other.position - transform.position;
			if (offset.sqrMagnitude < closeDistance * closeDistance)
			{
				//Debug.Log("You are close");

				if (Input.GetKeyUp (KeyCode.F))
				{
					Collect ();
				}
			}
			
		}
	}

	public InventoryItems Collect()
	{
		gameObject.SetActive (false);
		return id;
	}
}
