using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndBt()
    {
        Application.Quit();

        UnityEditor.EditorApplication.isPlaying = false;
    }

    /*public void NextBt(int Day)
    {
        SceneManager.LoadScene("Day " + Day);
    }*/
}
