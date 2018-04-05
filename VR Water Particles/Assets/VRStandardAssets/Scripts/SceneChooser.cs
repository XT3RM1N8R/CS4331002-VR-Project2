using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChooser : MonoBehaviour {

	public void SwitchSceneToDenver(){
		SceneManager.LoadScene("DenverScene", LoadSceneMode.Single);

	}

	public void SwitchScenetoEllsworth(){
		SceneManager.LoadScene ("EllsworthScene", LoadSceneMode.Single);
	}
}