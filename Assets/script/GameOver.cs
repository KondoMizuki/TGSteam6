using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Application.Quit();

            //UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    public void EndBt()
    {
        Application.Quit();

        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
