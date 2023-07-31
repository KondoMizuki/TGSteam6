using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sell : MonoBehaviour
{
    public ItemData Data;
    public ItemData Data2;
    public ItemData Data3;
    public ItemData Data4;
    public ItemData Data5;
    public ItemData Data6;
    public ItemData Data7;
    public ItemData Data8;
    public ItemData Data9;
    public ItemData Data10;

    public Text selltext;
    public Text backtext;

    public PlayerData P_S_Data;

    public PlayerPossessionItemData P_Data;

    public Text PossessionItemText;
    public Text priceText;

    public int SellGold;
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        foreach (string key in P_Data.PlayerPossessionItemList)
        {
            if (dic.ContainsKey(key))
            {
                dic[key]++;
            }
            else
            {
                dic.Add(key, 1);
            }
        }
        foreach (string key in dic.Keys)
        {
            PossessionItemText.text += key + "�~" + dic[key] + "\n";

            for (int i = 0; i <= dic[key]; i++)
            {
                switch (key)
                {
                    case "���[���̔�":
                        SellGold += Data.SellingPrice;
                        break;
                    case "���啨":
                        SellGold += Data2.SellingPrice;
                        break;
                    case "���̉�":
                        SellGold += Data3.SellingPrice;
                        break;
                    case "��":
                        SellGold += Data4.SellingPrice;
                        break;
                    case "�w偂̎�":
                        SellGold += Data5.SellingPrice;
                        break;
                    case "�I�I�J�~�̖є�":
                        SellGold += Data6.SellingPrice;
                        break;
                    case "�Őj":
                        SellGold += Data7.SellingPrice;
                        break;
                    case "���[���̉�":
                        SellGold += Data8.SellingPrice;
                        break;
                    case "�l�Y�~�̂�����":
                        SellGold += Data9.SellingPrice;
                        break;
                    case "�S�t":
                        SellGold += Data10.SellingPrice;
                        break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(count>1)
        {
            count = 1;
        }
        if(count <0 )
        {
            count = 0;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            count = count - 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            count = count + 1;
        }

        if(count == 0)
        {
            selltext.fontSize = 30;
            backtext.fontSize = 20;
        }
        else
        if(count == 1)
        {
            selltext.fontSize = 20;
            backtext.fontSize = 30;
        }
       

        priceText.text = "���p���v " + SellGold.ToString() + "G";
        if (count == 0 &&Input.GetKeyDown(KeyCode.Space))
        {
            P_S_Data.GOLD += SellGold;
            SellGold = 0;
            P_Data.PlayerPossessionItemList.Clear();
            PossessionItemText.text = "";
        }
        else
            if(count == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Shop");
        }
    }
}
