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

    public PlayerData P_S_Data;

    public PlayerPossessionItemData P_Data;

    public Text PossessionItemText;
    public Text priceText;

    public int SellGold;

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
            Debug.Log(key + " = " + dic[key]);
            PossessionItemText.text += key + "�~" + dic[key] + " , ";

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
        priceText.text = SellGold.ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            P_S_Data.GOLD += SellGold;
            SellGold = 0;
            P_Data.PlayerPossessionItemList.Clear();
            PossessionItemText.text = "";
        }
    }
}
