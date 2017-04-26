using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Startbuttonscript : MonoBehaviour {

	public void Update () {
		SceneManager.LoadScene ("Gamescreen");
        print("Halo");
	}
}
