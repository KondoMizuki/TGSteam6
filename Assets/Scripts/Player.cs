using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public int PlayerLife = 10;

    public int PlayerAttack = 5;

    public int DFE = 5;

    public int Spd = 5;

    public Text NameText;

    public Text PlayerLifeText;

  

    public string playername;

    // Start is called before the first frame update
    void Start()
    {
        NameText.text = "プレイヤー";
        playername = "プレイヤー";
    }

    // Update is called once per frame
    void Update()
    {
        PlayerLifeText.text = "体力 " + PlayerLife;
        
    }
}
