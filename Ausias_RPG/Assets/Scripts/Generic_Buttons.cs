using UnityEngine;
using System.Collections;

public class Generic_Buttons : MonoBehaviour {

	public void Exit_To_Menu()
	{
		GameObject ObjSceneManager = GameObject.Find("SceneManager");
		ObjSceneManager.GetComponent<SceneManager> ().gameSaver.SaveProgress (ObjSceneManager.GetComponent<SceneManager> ().gameData);
		ObjSceneManager.GetComponent<SceneManager> ().ChangeScene(0, false);
	}

	public void Leave_Game()
	{
		Application.Quit();
	}

	public void SaveANDLeave_Game()
	{
		GameObject ObjSceneManager = GameObject.Find("SceneManager");
		ObjSceneManager.GetComponent<SceneManager> ().gameSaver.SaveProgress (ObjSceneManager.GetComponent<SceneManager> ().gameData);
		Application.Quit();
	}

    public void Load_Level1()
    {
		AutoFade.LoadLevel(1 ,3,1,Color.black);
    }

	void TravelTo(int place)
	{
		GameObject ObjSceneManager = GameObject.Find("SceneManager");
		ObjSceneManager.GetComponent<SceneManager> ().ChangeScene (place, false);
	}
}
