using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{
	public Game_Data gameData;
	public Game_Saver gameSaver;

	private int current_scene;
	private bool debugState;

	private Canvas gui;

	static SceneManager Instance;

	void Awake()
	{
		gameData = null;
		gameData = new Game_Data ();
		gameData.Reset ();

		gameSaver = null;
		gameSaver = new Game_Saver ("GameSlots.txt");

		debugState = false;
		current_scene = 0;
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

		gui = GetComponentInChildren<Canvas> ();
	}
	
	void Update ()
	{
		// debug state variable control
		if (debugState)
		{
			if (Input.GetKeyUp(KeyCode.Keypad9))
			{
				debugState = false;
				Debug.Log("Debug Disabled");
			}

			// log gameData
			if (Input.GetKeyUp (KeyCode.I))
				Debug.Log(gameData);
		}
		else
		{
			if(Input.GetKeyUp(KeyCode.Keypad9))
			{
				debugState = true;
				Debug.Log("Debug Enabled");
			}
		}

		if(current_scene > 0 && current_scene < 7)
		{
			gui.enabled = true;

			if(current_scene > 1)
			{
				//gui.
			}
		}
		else
		{
			gui.enabled = false;
		}



	}

	public void ChangeScene(int newScene, bool willReturn)
	{
		if (!willReturn)
			gameData.last_scene = newScene;

		current_scene = newScene;
		Application.LoadLevel (newScene);
	}

	public void ReturnToPrevScene()
	{
		current_scene = gameData.last_scene;
		Application.LoadLevel (gameData.last_scene);
	}


}
