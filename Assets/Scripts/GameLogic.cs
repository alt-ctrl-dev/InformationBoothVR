using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

	public GameObject firstUI, secondUI;

	// Use this for initialization
	void Start () {
		if(firstUI!=null)firstUI.SetActive (true);
		if(secondUI!=null)secondUI.SetActive (false);
	}

	public void showSecondPanel(){
		if(firstUI!=null)firstUI.SetActive (false);
		if(secondUI!=null)secondUI.SetActive (true);
	}

	public void showNextScene(string scene){
		SceneManager.LoadSceneAsync (scene, LoadSceneMode.Single);
	}

	public void showNextSceneWithText(string scene){
		showSecondPanel ();
		SceneManager.LoadSceneAsync (scene, LoadSceneMode.Single);
	}
}
