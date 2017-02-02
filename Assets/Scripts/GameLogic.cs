using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

	public GameObject firstUI, secondUI;

	public void showSecondPanel(){
		firstUI.SetActive (false);
		secondUI.SetActive (true);
	}

	public void showNextScene(string scene){
		SceneManager.LoadSceneAsync (scene, LoadSceneMode.Single);
	}

}
