﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	private Vector3 inputValue;
	private float speedScaler=0.01f;
	private Camera localPlayerCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(!isLocalPlayer){return;}
		inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
		inputValue.y = 0f;
		inputValue.z += CrossPlatformInputManager.GetAxis("Vertical")*speedScaler;
		transform.Translate(inputValue);
		//Debug.Log(transform.position);
		Debug.Log( "X: "  + CrossPlatformInputManager.GetAxis("Horizontal"));
		Debug.Log( "Z: " + CrossPlatformInputManager.GetAxis("Vertical"));
	}

	public override void OnStartLocalPlayer(){
		GetComponentInChildren<Camera>().enabled = true;
	}
		
}
