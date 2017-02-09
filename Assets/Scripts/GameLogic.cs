using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

	public GameObject firstUI, secondUI;

	// Use this for initialization
	void Start () {
		firstUI.SetActive (true);
		secondUI.SetActive (false);
	}

	public void showSecondPanel(){
		firstUI.SetActive (false);
		secondUI.SetActive (true);
	}

	public void showNextScene(string scene){
		SceneManager.LoadSceneAsync (scene, LoadSceneMode.Single);
	}

}
