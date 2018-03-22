using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEmitter : MonoBehaviour {
  public int countDown = 1000;
  public GameObject sourceObject;
  public int currentCount;
	// Use this for initialization
	void Start () {
    currentCount = countDown;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentCount <= 0) {
      GameObject waterSphere = (GameObject)Instantiate(sourceObject, /*transform.position, transform.rotation,*/ transform);
      currentCount = countDown;
    } else {
      currentCount--;
    }
	}
}
