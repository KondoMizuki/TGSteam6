using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Equipment : MonoBehaviour
{ 

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

    public string Itemid;

    public string Item;


    // Start is called before the first frame update
    public void Start()
    {
        if (count == 0 && upcount == 0)
        {

            id = Data.id;
            Itemid = Data.Itemid;
            Enemyname = Data.Enemyname;
            Item = Data.Item;
            MaxLife = Data.EnemyMaxLife;
            Attack = Data.Attack;
            DFE = Data.DFE;
            SPD = Data.SPD;
            BuyGold = Data.BuyGold;

        }
        else
             if (count == 1 && upcount == 0)

        {
            id = Data2.id;
            Itemid = Data2.Itemid;
            Enemyname = Data2.Enemyname;
            Item = Data2.Item;
            MaxLife = Data2.EnemyMaxLife;
            Attack = Data2.Attack;
            DFE = Data2.DFE;
            SPD = Data2.SPD;
            BuyGold = Data2.BuyGold;
        }
           

            

        case 3:
            id = Data3.id;
            Itemid = Data3.Itemid;
            Enemyname = Data3.Enemyname;
            Item = Data3.Item;
            MaxLife = Data3.EnemyMaxLife;
            Attack = Data3.Attack;
            DFE = Data3.DFE;
            SPD = Data3.SPD;
            BuyGold = Data3.BuyGold;

            break;

        case 4:
            id = Data4.id;
            Itemid = Data4.Itemid;
            Enemyname = Data4.Enemyname;
            Item = Data4.Item;
            MaxLife = Data4.EnemyMaxLife;
            Attack = Data4.Attack;
            DFE = Data4.DFE;
            SPD = Data4.SPD;
            BuyGold = Data4.BuyGold;

            break;


    }
    }



    // Update is called once per frame
    void Update()
    {

    }
}