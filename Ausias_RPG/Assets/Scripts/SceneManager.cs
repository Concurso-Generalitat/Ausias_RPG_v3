using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{

	public Game_Data gameData;
	public Game_Saver gameSaver;
	private bool debugState;


	static SceneManager Instance;

	void Awake()
	{
		gameData = null;
		gameData = new Game_Data ();
		gameData.Reset ();

		gameSaver = null;
		gameSaver = new Game_Saver ("GameSlots.txt");

		debugState = false;
	}

	void Start ()
	{
		if (Instance != null)
		{
			GameObject.Destroy (gameObject);
		}
		else
		{
			GameObject.DontDestroyOnLoad(gameObject);
			Instance = this;
		}
	}
	
	void Update ()
	{
		// debug state variable control
		if (debugState)
		{
			if (Input.GetKeyUp(KeyCode.Keypad9)){
				debugState = false;
				Debug.Log("Debug Disabled");
			}

			// manual scene transition
			if (Input.GetKeyUp (KeyCode.Keypad0)) Application.LoadLevel (0);
			if (Input.GetKeyUp (KeyCode.Keypad1)) Application.LoadLevel (1);
			if (Input.GetKeyUp (KeyCode.Keypad2)) Application.LoadLevel (2);
			if (Input.GetKeyUp (KeyCode.Keypad3)) Application.LoadLevel (3);



			// log gameData
			if (Input.GetKeyUp (KeyCode.I))
				Debug.Log(gameData);


		} else {
			if(Input.GetKeyUp(KeyCode.Keypad9))
			{
				debugState = true;
				Debug.Log("Debug Enabled");
			}
		}
		





	}


}
