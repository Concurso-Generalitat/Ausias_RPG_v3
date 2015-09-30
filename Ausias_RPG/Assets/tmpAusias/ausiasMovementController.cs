using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]
public class ausiasMovementController : MonoBehaviour {

	public float speed = 20 , sensitivity = 20, gravity = 10;
	Vector3 movementDirection;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		CharacterController controller = GetComponent<CharacterController> ();


			movementDirection = new Vector3 (0, 0, Input.GetAxis ("Vertical"));
			movementDirection = transform.TransformDirection (movementDirection);
			movementDirection *= speed;
			movementDirection.y = 0;

		transform.Rotate (0, Input.GetAxis ("Horizontal") * sensitivity * Time.deltaTime, 0);
		movementDirection.y -= gravity * Time.deltaTime;

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) 
		{
			controller.Move (movementDirection * Time.deltaTime);
		}

	}
}
