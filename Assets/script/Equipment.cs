using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Equipment : MonoBehaviour
{
    public Shop shop;

    public EquipmentData Data;
    public EquipmentData Data2;
    public EquipmentData Data3;
    public EquipmentData Data4;

    public int MaxLife;

    public int Attack;

    public int DFE;

    public int SPD;

    public int BuyGold;

    //public Text EnemyLifeText;
    public string id;          //“o˜^ID

    public string Item;


    // Start is called before the first frame update
    public void Start()
    {

        
       

    }



    // Update is called once per frame
    void Update()
    {
       
        if (shop.count == 0)
        {
            id = Data.id;
            MaxLife = Data.MaxLife;
            Attack = Data.Attack;
            DFE = Data.DFE;
            SPD = Data.SPD;
            BuyGold = Data.BuyGold;
        }
        else
            if (shop.count == 1)
        {
            id = Data2.id;
            MaxLife = Data2.MaxLife;
            Attack = Data2.Attack;
            DFE = Data2.DFE;
            SPD = Data2.SPD;
            BuyGold = Data2.BuyGold;
        }
        else
         if (shop.count == 2)
        {
            id = Data3.id;
            Item = Data3.Item;
            MaxLife = Data3.MaxLife;
            Attack = Data3.Attack;
            DFE = Data3.DFE;
            SPD = Data3.SPD;
            BuyGold = Data3.BuyGold;
        }
        else
            if ( shop.count == 3)
        {
            id = Data4.id;
            MaxLife = Data4.MaxLife;
            Attack = Data4.Attack;
            DFE = Data4.DFE;
            SPD = Data4.SPD;
            BuyGold = Data4.BuyGold;
        }
    }
}