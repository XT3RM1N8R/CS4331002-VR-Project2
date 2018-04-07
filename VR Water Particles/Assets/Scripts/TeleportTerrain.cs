using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTerrain : MonoBehaviour {
	public GameObject[] objects;

	public void teleportLubbock(){
		var startingcam = GameObject.Find ("StartingCam");
		startingcam.SetActive (false);

		objects [0].SetActive (true);
		objects[0].transform.position = new Vector3(18,23, 27);
		Screen.lockCursor = true;

		var playerevent = GameObject.Find("TeleportPlayer");
		playerevent.SetActive (false);

		var canvas = GameObject.Find("Canvas");
		canvas.SetActive (false);

	}


	public void teleportDenver(){
		var startingcam = GameObject.Find ("StartingCam");
		startingcam.SetActive (false);

		objects [0].SetActive (true);
		objects[0].transform.position = new Vector3(51, 156, 53);
		Screen.lockCursor = true;

		var playerevent = GameObject.Find("TeleportPlayer");
		playerevent.SetActive (false);

		var canvas = GameObject.Find("Canvas");
		canvas.SetActive (false);

	}

	public void teleportEllsworth(){
		var startingcam = GameObject.Find ("StartingCam");
		startingcam.SetActive (false);

		objects [0].SetActive (true);
		objects[0].transform.position = new Vector3(18,6, 36);
		Screen.lockCursor = true;

		var playerevent = GameObject.Find("TeleportPlayer");
		playerevent.SetActive (false);

		var canvas = GameObject.Find("Canvas");
		canvas.SetActive (false);

	}
}
	
