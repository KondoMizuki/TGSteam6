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

        if (count > 4)//売る
        {
            count = count = 4;
        }
        if (count < -1)
        {
            count = count = -1;
        }

      

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            count = count + 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            count = count - 1;
        }
       


        if ( count == 0 )//剣
        {
            SwordText.fontSize = 30;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 20;
            heartText.fontSize = 20;
            sellText.fontSize = 20;
            backText.fontSize = 20;
        }
        else
        if (count == 1 )//ハート
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 20;
            heartText.fontSize = 30;
            sellText.fontSize = 20;
            backText.fontSize = 20;
        }
        else
        if (count == 2)//靴
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 30;
            heartText.fontSize = 20;
            sellText.fontSize = 20;
            backText.fontSize = 20;
        }
        else
        if ( count == 3)//ハート
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 30;
            ShoesText.fontSize = 20;
            heartText.fontSize = 20;
            sellText.fontSize = 20;
            backText.fontSize = 20;
        }
        else
        if (count == 4)//売る
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 20;
            heartText.fontSize = 20;
            sellText.fontSize = 30;
            backText.fontSize = 20;
        }
        if(count == -1)//戻る
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

            if((count != -1 && count != 4) && Data.GOLD >= equipment.BuyGold)
            {
                Data.PlayerMaxLife += equipment.MaxLife;
                Data.Attack += equipment.Attack;
                Data.DFE += equipment.DFE;
                Data.SPD += equipment.SPD;
                Data.GOLD -= equipment.BuyGold;
            }
            else
            if(count == 4)
            {
                SceneManager.LoadScene("Sell");
            }
            else
            if(count == -1)
            {
                SceneManager.LoadScene("Standby");
            }
        }

       
    }

    public void OnClickSword()
    {

    }
}
