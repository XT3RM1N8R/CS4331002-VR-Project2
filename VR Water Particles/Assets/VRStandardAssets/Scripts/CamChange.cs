using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamChange : MonoBehaviour {
	public GameObject[] objects;



	void Update () {
		if (Input.GetKeyDown("5")) {
			objects [0].SetActive (true);
			objects [1].SetActive (false);

		}

		if (Input.GetKeyDown("7")) {
			objects [0].SetActive (false);
			objects [1].SetActive (true);
		
		}
	}



}
