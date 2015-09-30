﻿using UnityEngine;
using System.Collections;

public class Inventory_Collectable : MonoBehaviour
{

	public Transform other;
	public GameObject message;
	public InventoryItems id = InventoryItems.CAMARA;
	public int closeDistance = 2;


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

				message.SetActive(true);

				if (Input.GetKeyUp (KeyCode.F))
				{
					Collect ();
				}
			}
			else
			{
				message.SetActive (false);
			}
			
		}

	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.rigidbody == other)
		{
			message.SetActive(true);

			if (Input.GetKeyUp (KeyCode.F))
			{
				Collect ();
			}
		}
	}

	void OnCollisionExit(Collision collisionInfo)
	{
		message.SetActive(false);
	}

	public InventoryItems Collect()
	{
		message.SetActive(false);
		gameObject.SetActive (false);
		return id;
	}



}
