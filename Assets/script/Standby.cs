using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Standby : MonoBehaviour
{
    public int count = 0;
    public GameObject cursor1;
    public GameObject cursor2;
    

    // Start is called before the first frame update
    void Start()
    {
        cursor1.SetActive(true);
        cursor2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 1)//ƒJ[ƒ\ƒ‹ˆÚ“®
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
            cursor1.SetActive(true);
            cursor2.SetActive(false);
        }
        else
            if (count == 1)
        {
            cursor1.SetActive(false);
            cursor2.SetActive(true);
        }

        if (count == 0 && Input.GetKey(KeyCode.Space))
        {
            
            SceneManager.LoadScene("Day1");

        }
        else
            if (count == 1 && Input.GetKey(KeyCode.Space))
        {

        }
    }
}
