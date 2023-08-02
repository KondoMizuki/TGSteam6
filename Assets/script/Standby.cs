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
        if (count > 1)//�J�[�\���ړ�
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
            NextText.fontSize = 30;
            ShopText.fontSize = 20;
        }
        else
            if (count == 1)
        {
            NextText.fontSize = 20;
            ShopText.fontSize = 30;
 
        }
        else

        

        if (count == 0  && Input.GetKey(KeyCode.Space))//�o�g����ʂ�
        {
            
            SceneManager.LoadScene("Day1");

        }
        else
            if (count == 1 && Input.GetKey(KeyCode.Space))//�V���b�v
        {
            SceneManager.LoadScene("Shop");
        }
       
    }
}
