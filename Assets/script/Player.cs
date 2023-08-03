using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public DropedItemData D_Data;

    public PlayerData Data;

    public int PlayerLife ;

    public int MaxLife;

    public int PlayerAttack ;

    public int DFE ;

    public int SPD ;

    public int GOLD;

    public Text NameText;

    public Text PlayerLifeText;

    public string playername;

    // Start is called before the first frame update
    void Start()
    {
        NameText.text = "プレイヤー";
        playername = "プレイヤー";

      
        playername = Data.Playername;
        PlayerLife = Data.Life;
        MaxLife = Data.PlayerMaxLife;
        PlayerAttack = Data.Attack;
        DFE = Data.DFE;
        SPD = Data.SPD;
        GOLD = Data.GOLD;

        D_Data.DropedItemList.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerLifeText.text = "体力 " + PlayerLife;
        GOLD = Data.GOLD;
    }
}
