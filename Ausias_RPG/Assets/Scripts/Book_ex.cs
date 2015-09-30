using UnityEngine;
using System.Collections;

public class Door_ex : MonoBehaviour {
	
	public Transform other;
	public GameObject message;
	public GameObject camara;
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
					Application.LoadLevel(4);
				}
				
			}
			else
			{
				message.SetActive (false);
			}
			
		}
		
	}
}
