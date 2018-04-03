using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTerrain : MonoBehaviour {

	public void camMainMove(){
		var player = GameObject.Find("FPSController");
		player.transform.position = new Vector3(0, 0, 0);
		Screen.lockCursor = true;
		var playerevent = GameObject.Find("EventSystem");
		playerevent.SetActive (false);

	}
}
	
