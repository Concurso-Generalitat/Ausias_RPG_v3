using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]
public class ausiasMovementController : MonoBehaviour {

	public float speed = 20 , sensitivity = 20, gravity = 10;
	public GameObject ausiastojump;
	Vector3 movementDirection;
	public float jumpForce;
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

		 
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) 
		 movementDirection.z = movementDirection.z / 2;


		controller.Move (movementDirection * Time.deltaTime);




	}
}
