using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public Player playerManager;

    public Enemy enemyManeger;

    public Item itemManager;

    public Log logManeger;

    public int PlayerDamage;

    public int EnemyDamage;

    public float _repeatSpan;

    public float _timeElaped;

    public int stage = 1;

    public static int endstage = 1;

    public bool isAttack = false;
    public bool isNext = false;
    public bool isHurt = false;

    public Text FloorText;

    public Text EndFloorText;

    // Start is called before the first frame update
    public void Start()
    {
        
        _repeatSpan = 4;//行動が行われるまでの時間
        _timeElaped = 2;//初期の行動までのやつ
        FloorText.text = "現在 " + stage + "階";//現在の階層
        EndFloorText.text = "最上階 " + endstage + "階";//終点
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
                logManeger.isFrist = true;
            }
        }

        if (enemyManeger.EnemyLife < 0)//体力が0以下にならない
        {
            enemyManeger.EnemyLife = 0;
        }

        if (playerManager.PlayerLife < 0)
        {
            playerManager.PlayerLife = 0;
        }

        if (playerManager.PlayerLife > playerManager.MaxLife)
        {
            playerManager.PlayerLife = playerManager.MaxLife;
        }

        
    }

    public void NextStage()
    {
        if (playerManager.PlayerLife > 0 && enemyManeger.EnemyLife == 0)//プレイヤーが生きてて敵が死んだ場合
        {
            int Ransu = Random.Range(1, 101);
            if (itemManager.Dropprobability >= Ransu)
            {
                Invoke(nameof(Drop), 1.0f);
            }

            if (stage == endstage)//終点と現在のステージが同じ場合終了違う場合次へ
            {
                logManeger.GameEnd();
                enemyManeger.EnemyLife = enemyManeger.EnemyMaxLife;//体力回復
                endstage = endstage + 1;//階層追加
                isNext = true;
                Invoke(nameof(scene), 2.0f);
            }
            else
            {
                logManeger.GameEnd();
                enemyManeger.EnemyLife = enemyManeger.EnemyMaxLife;//復活
                stage = stage + 1;
                isNext = true;
                Invoke(nameof(Endlog), 2.0f);
            }
        }
    }


    public void Drop()
    {
        logManeger.Drop();
    }


    public void Endlog()
    {
        enemyManeger.Start();
        itemManager.Start();
        logManeger.Start();
        playerManager.PlayerLife = playerManager.PlayerLife + 20; //回復
        _timeElaped = 0;//時間を０にする
        FloorText.text = "現在 " + stage + "階";//階層更新
        isNext = false;
    }

    public void scene()
    {
        
        SceneManager.LoadScene("Result");
        isNext = false;
    }

    public void battle()
    {

        if (playerManager.SPD > enemyManeger.SPD)//早いほうから行動
        {
            if (playerManager.PlayerLife > 0 && enemyManeger.EnemyLife > 0)
            {
                player();
                Invoke(nameof(NextStage), 1.0f);
            }
               
            if (enemyManeger.EnemyLife > 0 && playerManager.PlayerLife > 0)
            {
                
                Invoke(nameof(Enemy), 2.0f);
                Invoke(nameof(NextStage), 3.0f);
            }
               
        }
        else
        {
            if (enemyManeger.EnemyLife > 0 && playerManager.PlayerLife > 0)
            {
                
                Invoke(nameof(Enemy), 1.0f);
                NextStage();

            }
            if (playerManager.PlayerLife > 0 && enemyManeger.EnemyLife > 0)
            {
                Invoke(nameof(player), 2.0f);
                Invoke(nameof(NextStage), 3.0f);

            }
               
        }
    }

    void player()
    {
        int rad = Random.Range(0, 101);//クリティカル
        if (rad >= 95)
        {
            PlayerDamage = playerManager.PlayerAttack * 2;
        }
        else
        {
            PlayerDamage = playerManager.PlayerAttack - enemyManeger.DFE;
            if(PlayerDamage < 0)
            {
                PlayerDamage = 0;
            }
        }
        isAttack = true;
        enemyManeger.EnemyLife = enemyManeger.EnemyLife - PlayerDamage;
        logManeger.Damage1();
    }

    void Enemy()
    {
        EnemyDamage = enemyManeger.Attack - playerManager.DFE;
        if(EnemyDamage <= 0)
        {
            EnemyDamage = 1;
        }
        playerManager.PlayerLife = playerManager.PlayerLife - EnemyDamage;
        logManeger.Damage2();

        isHurt = true;
    } 
}
    

