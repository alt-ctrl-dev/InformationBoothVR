using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointLogic : MonoBehaviour {

	public GameObject player;
	public GameObject firstWP;
	public GameObject secondWP;
	public GameObject thirdWP;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position == firstWP.transform.position) {
			firstWP.SetActive (false);
		}
		if (player.transform.position == secondWP.transform.position) {
			secondWP.SetActive (false);
		}
		if (player.transform.position == thirdWP.transform.position) {
			thirdWP.SetActive (false);
		}
	}

	public void MoveToWaypoint(GameObject waypoint){
		Hashtable hashtable = new Hashtable();
		hashtable.Add("time", 3f);
		hashtable.Add("position", waypoint.transform.position);
		hashtable.Add("onComplete", "ShowWaypoints");
		hashtable.Add("onCompleteTarget",this.gameObject);
		hashtable.Add("onStart", "HideWaypoints");
		hashtable.Add("onStartTarget",this.gameObject);
		iTween.MoveTo( player, hashtable );
	}

	void HideWaypoints(){
		thirdWP.SetActive (false);
		secondWP.SetActive (false);
		firstWP.SetActive (false);
	}

	void ShowWaypoints(){
		print ("ShowWaypoints");
		thirdWP.SetActive (true);
		secondWP.SetActive (true);
		firstWP.SetActive (true);
	}

}
