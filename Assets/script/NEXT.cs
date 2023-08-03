using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NEXT : MonoBehaviour
{
    public int count = 0;
    public Text NextText;
    public Text EndText;

    // Start is called before the first frame update
    void Start()
    {

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
            NextText.fontSize = 30;
            EndText.fontSize = 20;
        }
        else
            if (count == 1)
        {
            NextText.fontSize = 20;
            EndText.fontSize = 30;
        }

        if (count == 0 && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Standby");
        }
        else
            if (count == 1 && Input.GetKey(KeyCode.Space))
        {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
            Application.Quit();//ゲームプレイ終了
#endif
        }
    }

    public void Onclicknext()
    {
        SceneManager.LoadScene("Standby");
    }
    public void Onclick()
    {
        SceneManager.LoadScene("Standby");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
        Application.Quit();//ゲームプレイ終了
#endif
    }


}
