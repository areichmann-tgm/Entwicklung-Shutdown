using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Startbuttonscript : MonoBehaviour {

    //Szene wird zum Gamescreen gewechselt
    public void ChangeSceneToGamescreen() {
		SceneManager.LoadScene ("Gamescreen");
        
	}

    //Szene wird zum Impressum gewechselt
    public void ChangeSceneToImpressum()
    {
        SceneManager.LoadScene("Impressum");

    }
}
