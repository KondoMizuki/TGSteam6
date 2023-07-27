using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Equipment equipment;
    public  Player player;
    public int count;
    public int upcount = 1;
    public Text SwordText;
    public Text ShildText;
    public Text ShoesText;
    public Text heartText;
    public Text backText;
    public Text sellText;
    public Text GoldText;

    public PlayerData Data;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GoldText.text = player.GOLD.ToString() + "G";

        if (count > 2)//売る
        {
            count = count = 2;
        }
        if (count < -2)
        {
            count = count = -2;
        }

        if(upcount > 0)
        {
            upcount = 0;
        }
        if(upcount < -1)
        {
            upcount = -1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            count = count + 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            count = count - 1;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            upcount = upcount + 1; 
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            upcount = upcount - 1;
        }


        if (upcount == 0 && count == 0 )//剣
        {
            SwordText.fontSize = 30;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 20;
            heartText.fontSize = 20;
            sellText.fontSize = 20;
            backText.fontSize = 20;
        }
        else
        if (count == 1 )//盾
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 30;
            ShoesText.fontSize = 20;
            heartText.fontSize = 20;
            sellText.fontSize = 20;
            backText.fontSize = 20;
        }
        else
        if (count == -1)//靴
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 30;
            heartText.fontSize = 20;
            sellText.fontSize = 20;
            backText.fontSize = 20;
        }
        else
        if (upcount == -1 && count == 0)//ハート
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 20;
            heartText.fontSize = 30;
            sellText.fontSize = 20;
            backText.fontSize = 20;
        }
        else
        if (count == 2)//売る
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 20;
            heartText.fontSize = 20;
            sellText.fontSize = 30;
            backText.fontSize = 20;
        }
        if(count == -2)//戻る
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 20;
            heartText.fontSize = 20;
            sellText.fontSize = 20;
            backText.fontSize = 30;
        }


        if (Input.GetKeyDown(KeyCode.Space))//共通処理
        {

            if((count != 2 || count != -2) && Data.GOLD >= equipment.BuyGold)

            {
                Data.PlayerMaxLife += equipment.MaxLife;
                Data.Attack += equipment.Attack;
                Data.DFE += equipment.DFE;
                Data.SPD += equipment.SPD;
                Data.GOLD -= equipment.BuyGold;
            }
            if(count == 2)
            {
                //SceneManager.LoadScene("Sell");
            }
            if(count == -2)
            {
                SceneManager.LoadScene("Standby");
            }
        }
    }
}
