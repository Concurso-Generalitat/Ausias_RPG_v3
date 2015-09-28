using UnityEngine;
using System.Collections;

public class Generic_Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void Exit_To_Menu()
	{
		Application.LoadLevel (0);
	}

	public void Leave_Game()
	{
		Application.Quit();
	}


}
