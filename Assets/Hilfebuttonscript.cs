using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Hilfebuttonscript : MonoBehaviour {

    //Szene wird zu Start gewechselt
    public void ChangeSceneToMainMenu()
    {
        SceneManager.LoadScene("start");

    }
}
