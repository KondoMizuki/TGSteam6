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

    //public Text EnemyLifeText;

    public string Enemyname;


    // Start is called before the first frame update
    public void Start()
    {
        if (gamemanager.stage == 1)
        {
            Enemyname = Data.Enemyname;
            EnemyLife = Data.Life;
            EnemyMaxLife = Data.EnemyMaxLife;
            Attack = Data.Attack;
            DFE = Data.DFE;
            SPD = Data.SPD;
        }else if(gamemanager.stage == 2)
        {
            Enemyname = Data2.Enemyname;
            EnemyLife = Data2.Life;
            EnemyMaxLife = Data2.EnemyMaxLife;
            Attack = Data2.Attack;
            DFE = Data2.DFE;
            SPD = Data2.SPD;
        }
        else if (gamemanager.stage == 3)
        {
            Enemyname = Data3.Enemyname;
            EnemyLife = Data3.Life;
            EnemyMaxLife = Data3.EnemyMaxLife;
            Attack = Data3.Attack;
            DFE = Data3.DFE;
            SPD = Data3.SPD;
        }
        else if (gamemanager.stage == 4)
        {
            Enemyname = Data4.Enemyname;
            EnemyLife = Data4.Life;
            EnemyMaxLife = Data4.EnemyMaxLife;
            Attack = Data4.Attack;
            DFE = Data4.DFE;
            SPD = Data4.SPD;
        }
        else if (gamemanager.stage == 5)
        {
            Enemyname = Data5.Enemyname;
            EnemyLife = Data5.Life;
            EnemyMaxLife = Data5.EnemyMaxLife;
            Attack = Data5.Attack;
            DFE = Data5.DFE;
            SPD = Data5.SPD;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}