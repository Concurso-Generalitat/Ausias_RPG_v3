using UnityEngine;
using System.Collections;

public class triggerAudioJump : MonoBehaviour {

	bool firstTime = true;
	bool playedAlready = false;
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		if (firstTime == false && playedAlready == false) {
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			playedAlready = true;
		} else
			firstTime = false;
		
	}
}
