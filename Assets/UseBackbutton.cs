using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UseBackbutton : MonoBehaviour
{

    public void Back()
    {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("start");

                
            }
        print("Hallo");
        
    }
}