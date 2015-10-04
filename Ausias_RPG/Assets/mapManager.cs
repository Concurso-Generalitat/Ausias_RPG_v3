using UnityEngine;
using System.Collections;

public class mapManager : MonoBehaviour {

	public bool active = true;
	// Use this for initialization
	void Start () {

		if (active)
			active = false;
		else
			active = true;
		this.gameObject.SetActive (active);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ShowNotShow(){

		if (active)
			active = false;
		else
			active = true;
		this.gameObject.SetActive (active);

	}
}
