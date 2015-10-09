using UnityEngine;
using System.Collections;

public class introCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Camera.main.fieldOfView > 40)
		Camera.main.fieldOfView = Camera.main.fieldOfView- 0.01f;

	}
}
