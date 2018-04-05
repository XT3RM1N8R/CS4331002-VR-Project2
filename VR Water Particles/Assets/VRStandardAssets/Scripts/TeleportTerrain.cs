using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTerrain : MonoBehaviour {
	public GameObject[] objects;


	public void camMainMove(){
		var startingcam = GameObject.Find ("StartingCam");
		startingcam.SetActive (false);

		objects [0].SetActive (true);
		objects[0].transform.position = new Vector3(50, 200, 50);
		Screen.lockCursor = true;

		var playerevent = GameObject.Find("TeleportPlayer");
		playerevent.SetActive (false);

		var canvas = GameObject.Find("Canvas");
		canvas.SetActive (false);

	}
}
	
