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
    public int upcount;
    public Text SwordText;
    public Text ShildText;
    public Text ShoesText;
    public Text heartText;
   

    // Start is called before the first frame update
    void Start()
    {
        
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

        if(upcount > 0)
        {
            upcount = 0;
        }
        if(upcount < -1)
        {
            upcount = -1;
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
            SwordText.fontSize = 30;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 20;
            heartText.fontSize = 20;
        }
        else
            if (count == 1 && upcount == 0)
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 30;
            ShoesText.fontSize = 20;
            heartText.fontSize = 20;
        }
        else
          if (count == 0 && upcount == -1)
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 30;
            heartText.fontSize = 20;
        }
        else
          if (count == 1 && upcount == -1)
        {
            SwordText.fontSize = 20;
            ShildText.fontSize = 20;
            ShoesText.fontSize = 20;
            heartText.fontSize = 30;
        }

        if (count == 0 && upcount == 0 && equipment.BuyGold <= player.GOLD && Input.GetKey(KeyCode.Space))
        {
            player.MaxLife = player.MaxLife + equipment.MaxLife;
            player.PlayerAttack = player.PlayerAttack + equipment.Attack;
            player.DFE = player.DFE + equipment.DFE;
            player.SPD = player.SPD + equipment.SPD;

        }
        else
            if (count == 1 && upcount == 0 && equipment.BuyGold <= player.GOLD && Input.GetKey(KeyCode.Space))
        {
            player.MaxLife = player.MaxLife + equipment.MaxLife;
            player.PlayerAttack = player.PlayerAttack + equipment.Attack;
            player.DFE = player.DFE + equipment.DFE;
            player.SPD = player.SPD + equipment.SPD;

        }
        else
            if (count == 0 && upcount == -1 && equipment.BuyGold <= player.GOLD && Input.GetKey(KeyCode.Space))
        {
            player.MaxLife = player.MaxLife + equipment.MaxLife;
            player.PlayerAttack = player.PlayerAttack + equipment.Attack;
            player.DFE = player.DFE + equipment.DFE;
            player.SPD = player.SPD + equipment.SPD;

        }
        else
            if (count == 1 && upcount == -1 && equipment.BuyGold <= player.GOLD && Input.GetKey(KeyCode.Space))
        {
            player.MaxLife = player.MaxLife + equipment.MaxLife;
            player.PlayerAttack = player.PlayerAttack + equipment.Attack;
            player.DFE = player.DFE + equipment.DFE;
            player.SPD = player.SPD + equipment.SPD;

        }

    }
}
