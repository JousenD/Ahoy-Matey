using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost(){
		StartHost();
		Debug.Log (Time.timeSinceLevelLoad);
	}

	public override void OnStartHost ()
	{
		Debug.Log (Time.timeSinceLevelLoad);
	}
}
