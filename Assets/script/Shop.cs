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
    public Text attack;
    public Text heart;
    public Text shoes;
    public Text shield;
    public Text GoldText;

    public PlayerData Data;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attack.text = Data.Attack.ToString();
        heart.text = Data.PlayerMaxLife.ToString();
        shoes.text = Data.SPD.ToString();
        shield.text = Data.DFE.ToString();
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
       


        if ( count == 0 )//ハート
        {
            SwordText.fontSize = 30;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 20;
            heartText.fontSize = 20;
            sellText.fontSize = 20;
            backText.fontSize = 20;
        }
        else
        if (count == 1 )//剣
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
        if ( count == 3)//盾
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
                buy();
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

    public void OnClickHP()
    {
        count = 0;
        Invoke(nameof(buy), 0.1f);
    }
    public void OnClickAtack()
    {
        count = 1;
        Invoke(nameof(buy), 0.1f);
    }
    public void OnClickSPD()
    {
        count = 2;
        Invoke(nameof(buy), 0.1f);
    }
    public void OnClickDFE()
    {
        count = 3;
        Invoke(nameof(buy), 0.1f);
    }
    public void OnClickback()
    {
        count = -1;
        SceneManager.LoadScene("Standby");
    }

    public void OnClicksell()
    {
        count = -1;
        SceneManager.LoadScene("Sell");
    }
    public void buy()
    {
        Data.PlayerMaxLife += equipment.MaxLife;
        Data.Attack += equipment.Attack;
        Data.DFE += equipment.DFE;
        Data.SPD += equipment.SPD;
        Data.GOLD -= equipment.BuyGold;
    }
}
