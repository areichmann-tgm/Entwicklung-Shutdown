using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Impressumbuttonscript : MonoBehaviour
{
    //Szene wird zu Start gewechselt
    public void ChangeSceneToMainMenu()
    {
        SceneManager.LoadScene("start");

    }
}
