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
    public EnemyData Data6;
    public EnemyData Data7;
    public EnemyData Data8;
    public EnemyData Data9;
    public EnemyData Data10;

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

            case 6:
                id = Data6.id;
                Itemid = Data6.Itemid;
                Enemyname = Data6.Enemyname;
                Item = Data6.Item;
                EnemyLife = Data6.Life;
                EnemyMaxLife = Data6.EnemyMaxLife;
                Attack = Data6.Attack;
                DFE = Data6.DFE;
                SPD = Data6.SPD;
                DORPGOLD = Data6.DORPGOLD;
                break;

            case 7:
                id = Data7.id;
                Itemid = Data7.Itemid;
                Enemyname = Data7.Enemyname;
                Item = Data7.Item;
                EnemyLife = Data7.Life;
                EnemyMaxLife = Data7.EnemyMaxLife;
                Attack = Data7.Attack;
                DFE = Data7.DFE;
                SPD = Data7.SPD;
                DORPGOLD = Data7.DORPGOLD;
                break;

            case 8:
                id = Data8.id;
                Itemid = Data8.Itemid;
                Enemyname = Data8.Enemyname;
                Item = Data8.Item;
                EnemyLife = Data8.Life;
                EnemyMaxLife = Data8.EnemyMaxLife;
                Attack = Data8.Attack;
                DFE = Data8.DFE;
                SPD = Data8.SPD;
                DORPGOLD = Data8.DORPGOLD;
                break;

            case 9:
                id = Data9.id;
                Itemid = Data9.Itemid;
                Enemyname = Data9.Enemyname;
                Item = Data9.Item;
                EnemyLife = Data9.Life;
                EnemyMaxLife = Data9.EnemyMaxLife;
                Attack = Data9.Attack;
                DFE = Data9.DFE;
                SPD = Data9.SPD;
                DORPGOLD = Data9.DORPGOLD;
                break;
            case 10:
                id = Data10.id;
                Itemid = Data10.Itemid;
                Enemyname = Data10.Enemyname;
                Item = Data10.Item;
                EnemyLife = Data10.Life;
                EnemyMaxLife = Data10.EnemyMaxLife;
                Attack = Data10.Attack;
                DFE = Data10.DFE;
                SPD = Data10.SPD;
                DORPGOLD = Data10.DORPGOLD;
                break;
        }
    }
        
   

    // Update is called once per frame
    void Update()
    {
       
    }
}