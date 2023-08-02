using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text GamrOverText;

    // Start is called before the first frame update
    void Start()
    {
        GamrOverText.text = "GameOver";
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
}
