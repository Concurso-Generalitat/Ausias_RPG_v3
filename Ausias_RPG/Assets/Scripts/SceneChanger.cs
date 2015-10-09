using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneCharger : MonoBehaviour
{
	public Transform ausias;
	public int closeDistance = 2;

	public int destinyScene;
	public bool willReturn = true;

	public GameObject ObjSceneManager;

	public GameObject message;
	//public GameObject image;
	//public Text text;

	void Start()
	{
		ObjSceneManager = GameObject.Find("SceneManager");
	}
	void Update()
	{
		if (ausias)
		{
			Vector3 offset = ausias.position - transform.position;
			if (offset.sqrMagnitude < closeDistance * closeDistance)
			{
				message.SetActive(true);
				
				if (Input.GetKeyUp (KeyCode.F))
				{
					ObjSceneManager.GetComponent<SceneManager> ().ChangeScene(destinyScene, willReturn);
				}
			}
			else
			{
				message.SetActive (false);
			}
			
		}
	}
}