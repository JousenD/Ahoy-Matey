using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost(){
		StartHost();
		Debug.Log (Time.timeSinceLevelLoad + " sec starting host.");
	}

	public override void OnStartHost ()
	{
		Debug.Log (Time.timeSinceLevelLoad+ " sec Host has started.");
	}

	public override void OnStartClient (NetworkClient myClient)
	{
		Debug.Log (Time.timeSinceLevelLoad+ " sec Client has started.");
		InvokeRepeating("PrintDots", 0f, 1f);
	}
	public override void OnClientConnect(NetworkConnection conn)
	{
		Debug.Log (Time.timeSinceLevelLoad+ " sec Connected to the client with IP: " + conn.address);
		CancelInvoke();
	}

	void PrintDots(){
		Debug.Log(".");
	}

}
