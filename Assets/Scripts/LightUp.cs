using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUp : MonoBehaviour {

	public Material lightUpMaterial = null;
	private Material defaultMaterial = null;
	private bool isLitUp = false;
	public Canvas canvas = null;

	// Use this for initialization
	void Start () {
		defaultMaterial = this.GetComponent<MeshRenderer> ().material; //Save our initial material as the default
		isLitUp = false;
	}

	// Update is called once per frame
	void Update () {
	}
		
	public void playerSelection() {
		if (!isLitUp) {
			objectLightUp();
			isLitUp = true;
		} else {
			aestheticReset ();
			isLitUp = false;
		}
		ToggleInformation ();
	}

	private void aestheticReset() {
		this.GetComponent<MeshRenderer>().material = defaultMaterial; //Revert to the default material
		//this.GetComponent<GvrAudioSource> ().Stop (); //Stop the audio attached
	}

	private void objectLightUp() { //Lightup behavior when the pattern shows.
		this.GetComponent<MeshRenderer>().material = lightUpMaterial; //Assign the hover material
		//this.GetComponent<GvrAudioSource> ().Play (); //Play the audio attached
	}

	private void ToggleInformation(){
		canvas.gameObject.SetActive (isLitUp);
		print ("!@#!@$"+isLitUp);
	}
}
