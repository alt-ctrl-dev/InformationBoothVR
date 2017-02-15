using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShaderTexture : MonoBehaviour {

	public Material shader;

	public Texture[] textures;

	private int index;

	// Use this for initialization
	void Start () {
		index = (int)Random.Range (0f, textures.Length);
		ChangeImage ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeImage(){
		shader.SetTexture ("_Tex", textures [index]);
		index++;
		if (index >= textures.Length)
			index = 0;
	}
}
