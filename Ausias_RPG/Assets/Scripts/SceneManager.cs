using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{
	public Game_Data gameData;
	public Game_Saver gameSaver;

	private int current_scene;
	private bool debugState;

	private GameObject gui;

	static SceneManager Instance;

	private bool sceneChanged;

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

		if(sceneChanged)
		{
			if(current_scene > 0 && current_scene < 7)
			{
				if(current_scene < 2) // biblio
				{
					gui = GameObject.FindGameObjectWithTag("GUI1");
				}
				else if (gameData.act > 1 && gameData.progress >= 30)
				{
					gui = GameObject.FindGameObjectWithTag("GUI3");
				}
				else
				{
					gui = GameObject.FindGameObjectWithTag("GUI2");
				}

				gui.SetActive(true);
			}

			sceneChanged = false;
		}
	}

	public void ChangeScene(int newScene, bool willReturn)
	{
		if (!willReturn)
			gameData.last_scene = newScene;

		current_scene = newScene;
		sceneChanged = true;
		gui.SetActive (false);
		AutoFade.LoadLevel(newScene ,3,1,Color.black);
	}

	public void ReturnToPrevScene()
	{
		current_scene = gameData.last_scene;
		sceneChanged = true;
		gui.SetActive (false);
		AutoFade.LoadLevel(gameData.last_scene ,3,1,Color.black);
	}


}
