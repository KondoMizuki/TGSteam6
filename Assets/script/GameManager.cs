using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player playerManager;

    public Enemy enemyManeger;

    public Log logManeger;

    public int PlayerDamage;

    public int EnemyDamage;

    public float _repeatSpan;

    public float _timeElaped;

    // Start is called before the first frame update
    void Start()
    {
        _repeatSpan = 4;//行動が行われるまでの時間
        _timeElaped = 2;//初期の行動までのやつ
        
    }

    // Update is called once per frame
    void Update()
    {

        _timeElaped += Time.deltaTime;
        if (playerManager.PlayerLife > 0 | enemyManeger.EnemyLife > 0)
        {
            if (_timeElaped >= _repeatSpan)//_repeatSpanが_timeElaped以上になったらバトルをする
            {
                battle();
                _timeElaped = 0;//時間を０にする

            }

            if (enemyManeger.EnemyLife < 0)//体力が0以下にならない
            {
                enemyManeger.EnemyLife = 0;

            }

            if (playerManager.PlayerLife < 0)
            {
                playerManager.PlayerLife = 0;
            }

        }

        
       
    }

    public void rad()
    {
        int rad = Random.Range(0, 2);
    }

    public void battle()
    {
        if (playerManager.SPD > enemyManeger.SPD)
        {
            player();
            Invoke(nameof(Enemy), 2.0f);
        }
        else
            if(enemyManeger.SPD > playerManager.SPD)
        {
            Enemy();
            Invoke(nameof(player), 2.0f);
        }
       


    }

    void player()
    {
        PlayerDamage = playerManager.PlayerAttack - enemyManeger.DFE;
        if(playerManager.PlayerLife > 0 && enemyManeger.EnemyLife > 0)
        {
            enemyManeger.EnemyLife = enemyManeger.EnemyLife - PlayerDamage;
            logManeger.Damage1();
        }
    }
    void Enemy()
    {
        EnemyDamage = enemyManeger.Attack - playerManager.DFE;
        if(enemyManeger.EnemyLife > 0 && playerManager.PlayerLife > 0)
        {
            playerManager.PlayerLife = playerManager.PlayerLife - EnemyDamage;
            logManeger.Damage2();
        }
    }
    
}
