using UnityEngine;
using System.Collections;

public class AusiasControllerScript : MonoBehaviour {

	Animator anim;

	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		float move = Input.GetAxis ("Vertical");

		anim.SetFloat ("Speed", move);
	
	}
}
