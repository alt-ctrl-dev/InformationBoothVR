using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayer : MonoBehaviour {

	MovieTexture movTex;

	void Start()
	{
		movTex = (MovieTexture)GetComponent<Renderer>().material.mainTexture;
		movTex.Play(); // Autoplay on start
		movTex.loop = true; // Loop forever
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
