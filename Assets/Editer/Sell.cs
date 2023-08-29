using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

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
    public DropedItemData D_Data;
    public PlayerPossessionItemData P_Data;

    public Text PossessionItemText;
    public Text priceText;
    public Text ATK;
    public Text HP;
    public Text SPD;
    public Text DFE;
    public Text Gold;

    public int SellGold;
    public int PossessionItem;
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        PossessionItem = P_Data.PlayerPossessionItemList.Count;

        if (PossessionItem == 0)
        {
            PossessionItemText.text = "売れるものがありません。\nまたのお越しをお待ちしております。";
        }
        else if (PossessionItem >= 1)
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
                PossessionItemText.text += key + "×" + dic[key] + "\n";

                for (int i = 0; i <= dic[key]; i++)
                {
                    switch (key)
                    {
                        case "ワームの皮":
                            SellGold += Data.SellingPrice;
                            break;
                        case "分泌物":
                            SellGold += Data2.SellingPrice;
                            break;
                        case "魂の炎":
                            SellGold += Data3.SellingPrice;
                            break;
                        case "牙":
                            SellGold += Data4.SellingPrice;
                            break;
                        case "蜘蛛の糸":
                            SellGold += Data5.SellingPrice;
                            break;
                        case "オオカミの毛皮":
                            SellGold += Data6.SellingPrice;
                            break;
                        case "毒針":
                            SellGold += Data7.SellingPrice;
                            break;
                        case "ワームの牙":
                            SellGold += Data8.SellingPrice;
                            break;
                        case "ネズミのしっぽ":
                            SellGold += Data9.SellingPrice;
                            break;
                        case "粘液":
                            SellGold += Data10.SellingPrice;
                            break;
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        HP.text = P_S_Data.PlayerMaxLife.ToString();
        ATK.text = P_S_Data.Attack.ToString();
        DFE.text = P_S_Data.DFE.ToString();
        SPD.text = P_S_Data.SPD.ToString();
        Gold.text = P_S_Data.GOLD.ToString();

        if (count>1)
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
       

        priceText.text = "売却合計 " + SellGold.ToString() + "G";
        if (count == 0 &&Input.GetKeyDown(KeyCode.Space))
        {
            P_S_Data.GOLD += SellGold;
            SellGold = 0;
            P_Data.PlayerPossessionItemList.Clear();

            //ダーティとしてマークする(変更があった事を記録する)
            //EditorUtility.SetDirty(P_Data);

            //保存する
            //AssetDatabase.SaveAssets();

            PossessionItemText.text = "売れるものがありません。\nまたのお越しをお待ちしております。";
        }
        else
            if(count == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Shop");
        }
    }

    public void OnClicksell()
    {
        P_S_Data.GOLD += SellGold;
        SellGold = 0;
        P_Data.PlayerPossessionItemList.Clear();

        //ダーティとしてマークする(変更があった事を記録する)
        //EditorUtility.SetDirty(P_Data);

        //保存する
        //AssetDatabase.SaveAssets();

        PossessionItemText.text = "売れるものがありません。\nまたのお越しをお待ちしております。";
    }
    public void OnClickback()
    {
        SceneManager.LoadScene("Standby");
    }
}
