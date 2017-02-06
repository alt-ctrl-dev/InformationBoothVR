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
		
	}

	public void MoveToFirstWP(){
		Hashtable hashtable = new Hashtable();
		hashtable.Add("time", 3f);
		hashtable.Add("position", firstWP.transform.position);
		hashtable.Add("onComplete", "ShowWaypoints");
		hashtable.Add("onCompleteTarget",this.gameObject);
		hashtable.Add("onStart", "HideWaypoints");
		hashtable.Add("onStartTarget",this.gameObject);
		iTween.MoveTo(player, hashtable);
	}

	public void MoveToSecondWP(){
		Hashtable hashtable = new Hashtable();
		hashtable.Add("time", 3f);
		hashtable.Add("position", secondWP.transform.position);
		hashtable.Add("onComplete", "ShowWaypoints");
		hashtable.Add("onCompleteTarget",this.gameObject);
		hashtable.Add("onStart", "HideWaypoints");
		hashtable.Add("onStartTarget",this.gameObject);
		iTween.MoveTo( player, hashtable );
	}

	public void MoveToThirdWP(){
		Hashtable hashtable = new Hashtable();
		hashtable.Add("time", 3f);
		hashtable.Add("position", thirdWP.transform.position);
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
