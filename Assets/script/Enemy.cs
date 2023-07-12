using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameManager gamemanager;

    public EnemyData Data;
    public EnemyData Data2;
    public EnemyData Data3;
    public EnemyData Data4;
    public EnemyData Data5;

    public int EnemyLife;

    public int EnemyMaxLife;

    public int Attack;

    public int DFE;

    public int SPD;

    public int DORPGOLD;

    //public Text EnemyLifeText;
    public string id;          //“o˜^ID

    public string Enemyname;

    public string Itemid;

    public string Item;


    // Start is called before the first frame update
    public void Start()
    {
        switch (gamemanager.stage)
        {
            case 1:
                id = Data.id;
                Itemid = Data.Itemid;
                Enemyname = Data.Enemyname;
                Item = Data.Item;
                EnemyLife = Data.Life;
                EnemyMaxLife = Data.EnemyMaxLife;
                Attack = Data.Attack;
                DFE = Data.DFE;
                SPD = Data.SPD;
                DORPGOLD = Data.DORPGOLD;

                break;

            case 2:
                id = Data2.id;
                Itemid = Data2.Itemid;
                Enemyname = Data2.Enemyname;
                Item = Data2.Item;
                EnemyLife = Data2.Life;
                EnemyMaxLife = Data2.EnemyMaxLife;
                Attack = Data2.Attack;
                DFE = Data2.DFE;
                SPD = Data2.SPD;
                DORPGOLD = Data2.DORPGOLD;
                break;

            case 3:
                id = Data3.id;
                Itemid = Data3.Itemid;
                Enemyname = Data3.Enemyname;
                Item = Data3.Item;
                EnemyLife = Data3.Life;
                EnemyMaxLife = Data3.EnemyMaxLife;
                Attack = Data3.Attack;
                DFE = Data3.DFE;
                SPD = Data3.SPD;
                DORPGOLD = Data3.DORPGOLD;
                break;

            case 4:
                id = Data4.id;
                Itemid = Data4.Itemid;
                Enemyname = Data4.Enemyname;
                Item = Data4.Item;
                EnemyLife = Data4.Life;
                EnemyMaxLife = Data4.EnemyMaxLife;
                Attack = Data4.Attack;
                DFE = Data4.DFE;
                SPD = Data4.SPD;
                DORPGOLD = Data4.DORPGOLD;
                break;

            case 5:
                id = Data5.id;
                Itemid = Data5.Itemid;
                Enemyname = Data5.Enemyname;
                Item = Data5.Item;
                EnemyLife = Data5.Life;
                EnemyMaxLife = Data5.EnemyMaxLife;
                Attack = Data5.Attack;
                DFE = Data5.DFE;
                SPD = Data5.SPD;
                DORPGOLD = Data5.DORPGOLD;
                break;
        }
    }
        
   

    // Update is called once per frame
    void Update()
    {
       
    }
}