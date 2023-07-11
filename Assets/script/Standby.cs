using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Standby : MonoBehaviour
{
    public int count = 0;
    public int upcount = 0;
    public Text NextText;
    public Text ShopText;
    public Text BackText;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 1)//ÉJÅ[É\Éãà⁄ìÆ
        {
            count =  1;
        }
        if (count < 0)
        {
            count =  0;
        }
        if(upcount < 0)
        {
            upcount = 0;
        }
        if(upcount > 1)
        {
            upcount = 1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            count = count + 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            count = count - 1;
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            upcount = upcount + 1;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            upcount = upcount - 1;
        }

        if (count == 0 && upcount == 0)
        {
            NextText.fontSize = 30;
            ShopText.fontSize = 20;
            BackText.fontSize = 20;
        }
        else
            if (count == 1 && upcount == 0)
        {
            NextText.fontSize = 20;
            ShopText.fontSize = 30;
            BackText.fontSize = 20;
        }
        else
        if(upcount == 1)
        {
            NextText.fontSize = 20;
            ShopText.fontSize = 20;
            BackText.fontSize = 30;
        }

        if (count == 0 && upcount == 0 && Input.GetKey(KeyCode.Space))
        {
            
            SceneManager.LoadScene("Day1");

        }
        else
            if (count == 1 && upcount == 0 && Input.GetKey(KeyCode.Space))
        {

        }
        else
            if(upcount == 1 && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Title");
        }
    }
}
