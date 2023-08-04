using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class Title : MonoBehaviour
{
    public int count = 0;
    public Text StartText;
    public Text OptionText;
    
     public PlayerData Data;

    // Start is called before the first frame update
    void Awake()
    {
        
        Data.PlayerMaxLife = 30;
        Data.Attack = 7;
        Data.DFE = 3;
        Data.SPD = 5;
        Data.GOLD = 1000;

        //ダーティとしてマークする(変更があった事を記録する)
        EditorUtility.SetDirty(Data);

        //保存する
        AssetDatabase.SaveAssets();
    }
    void Start()
    {
        Data.PlayerMaxLife = 30;
        Data.Attack = 7;
        Data.DFE = 3;
        Data.SPD = 5;
        Data.GOLD = 1000;

        //ダーティとしてマークする(変更があった事を記録する)
        EditorUtility.SetDirty(Data);

        //保存する
        AssetDatabase.SaveAssets();
    }

    // Update is called once per frame
    void Update()
    {

        if ( Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Standby");
        }
       
    }
    public void OnClick()
    {
        SceneManager.LoadScene("Standby");
    }
}
