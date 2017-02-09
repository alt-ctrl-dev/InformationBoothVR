using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointLogic : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void MoveToWaypoint(GameObject waypoint){
		if (player.transform.position != waypoint.transform.position) {
			Hashtable hashtable = new Hashtable ();
			hashtable.Add ("time", 3f);
			hashtable.Add ("position", waypoint.transform.position);
			hashtable.Add ("onComplete", "StopWalkingAudio");
			hashtable.Add ("onCompleteTarget", this.gameObject);
			hashtable.Add ("onStart", "PlayWalkingAudio");
			hashtable.Add ("onStartTarget", this.gameObject);
			iTween.MoveTo (player, hashtable);
		}
	}

	void StopWalkingAudio(){
		player.GetComponent<GvrAudioSource> ().Stop ();
	}

	void PlayWalkingAudio(){
		player.GetComponent<GvrAudioSource> ().Play ();
	}

}
