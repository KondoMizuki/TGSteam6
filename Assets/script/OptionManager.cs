using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    //インスペクターウィンドウからゲームオブジェクトを設定する
    public GameObject OptionPanel;

    // Start is called before the first frame update
    void Start()
    {
        OptionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionPanel.SetActive(!OptionPanel.activeSelf);
        }
    }
}
