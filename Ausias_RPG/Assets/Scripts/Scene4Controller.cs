using UnityEngine;
using System.Collections;

public class Scene4Controller : MonoBehaviour {

	private int ticks;

	// Use this for initialization
	void Start () {
		ticks = 0;
	}
	
	// Update is called once per frame
	void Update () {
		ticks++;
		if (ticks >= 200 || Input.GetKeyUp (KeyCode.F)) {
			Application.LoadLevel(0);
		}
	}
}
