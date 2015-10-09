using UnityEngine;
using System.Collections;

public class SceneCharger : MonoBehaviour
{
	public Transform ausias;
	public int closeDistance = 2;

	public int destinyScene;
	public bool willReturn = true;

	public GameObject message;

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
					GameObject ObjSceneManager = GameObject.Find("SceneManager");
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