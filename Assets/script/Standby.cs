using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Standby : MonoBehaviour
{
    public int count = 1;
    public Text NextText;
    public Text ShopText;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 1)//カーソル移動
        {
            count = 1;
        }
        if (count < 0)
        {
            count = 0;
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
            NextText.fontSize = 40;
            ShopText.fontSize = 50;
        }
        else
            if (count == 1)
        {
            NextText.fontSize = 50;
            ShopText.fontSize = 40;
 
        }

        

        if (count == 1  && Input.GetKey(KeyCode.Space))//バトル画面へ
        {
            
            SceneManager.LoadScene("Day1");

        }
        else
            if (count == 0 && Input.GetKey(KeyCode.Space))//ショップ
        {
            SceneManager.LoadScene("Shop");
        }
       
    }
    public void OnclickStart()
    {
        SceneManager.LoadScene("Day1");
    }
    public void OnclickShop()
    {
        SceneManager.LoadScene("Shop");
    }

}
