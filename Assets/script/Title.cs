using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    public int count = 0;
    public Text StartText;
    public Text OptionText;
    
     public PlayerData Data;

    // Start is called before the first frame update
    void Start()
    {
       Data.PlayerMaxLife = 30;
       Data.Attack = 7;
       Data.DFE = 3;
       Data.SPD = 5;
       Data.GOLD = 1000;
        Debug.Log("Startメソッドは動きました。");
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 1)//カーソル移動
        {
            count = count = 1;
        }
        if (count < 0)
        {
            count = count = 0;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            count = count + 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            count = count - 1;
        }


        if (count == 0)
        {
            StartText.fontSize = 30;
            OptionText.fontSize = 20;
        }
        else
            if (count == 1)
        {
            StartText.fontSize = 20;
            OptionText.fontSize = 30;
        }

        if (count == 0 && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Standby");
        }
        else
            if (count == 1 && Input.GetKey(KeyCode.Space))
        {

        }
    }
}
