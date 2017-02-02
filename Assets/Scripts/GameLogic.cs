using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

	public GameObject firstUI, secondUI;

	// Use this for initialization
	void Start () {
		secondUI.SetActive (false);
		if(!firstUI.activeSelf)firstUI.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showSecondPanel(){
		firstUI.SetActive (false);
		secondUI.SetActive (true);
	}

	public void showNextScene(){
		SceneManager.LoadSceneAsync ("Office", LoadSceneMode.Single);
	}

}
