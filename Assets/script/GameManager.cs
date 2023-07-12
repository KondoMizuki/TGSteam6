using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public Text FloorText;

    public Text EndFloorText;

    // Start is called before the first frame update
    public void Start()
    {
        
        _repeatSpan = 4;//s“®‚ªs‚í‚ê‚é‚Ü‚Å‚ÌŠÔ
        _timeElaped = 2;//‰Šú‚Ìs“®‚Ü‚Å‚Ì‚â‚Â
        FloorText.text = "Œ»İ " + stage + "ŠK";//Œ»İ‚ÌŠK‘w
        EndFloorText.text = "ÅãŠK " + endstage + "ŠK";//I“_
    }

    // Update is called once per frame
    void Update()
    {
        _timeElaped += Time.deltaTime;
        if (playerManager.PlayerLife > 0 | enemyManeger.EnemyLife > 0)
        {
            if (_timeElaped >= _repeatSpan)//_repeatSpan‚ª_timeElapedˆÈã‚É‚È‚Á‚½‚çƒoƒgƒ‹‚ğ‚·‚é
            {
                battle();
                _timeElaped = 0;//ŠÔ‚ğ‚O‚É‚·‚é
                logManeger.isFrist = true;
            }
        }

        if (enemyManeger.EnemyLife < 0)//‘Ì—Í‚ª0ˆÈ‰º‚É‚È‚ç‚È‚¢
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
        if (playerManager.PlayerLife > 0 && enemyManeger.EnemyLife == 0)//ƒvƒŒƒCƒ„[‚ª¶‚«‚Ä‚Ä“G‚ª€‚ñ‚¾ê‡
        {
            int Ransu = Random.Range(1, 101);
            if (itemManager.Dropprobability >= Ransu)
            {
                Invoke(nameof(Drop), 1.0f);
            }

            if (stage == endstage)//I“_‚ÆŒ»İ‚ÌƒXƒe[ƒW‚ª“¯‚¶ê‡I—¹ˆá‚¤ê‡Ÿ‚Ö
            {
                logManeger.GameEnd();
                enemyManeger.EnemyLife = enemyManeger.EnemyMaxLife;//‘Ì—Í‰ñ•œ
                endstage = endstage + 1;//ŠK‘w’Ç‰Á
                Invoke(nameof(scene), 2.0f);
            }
            else
            {
                logManeger.GameEnd();
                enemyManeger.EnemyLife = enemyManeger.EnemyMaxLife;//•œŠˆ
                stage = stage + 1;
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
        playerManager.PlayerLife = playerManager.PlayerLife + 20; //‰ñ•œ
        _timeElaped = 0;//ŠÔ‚ğ‚O‚É‚·‚é
        FloorText.text = "Œ»İ " + stage + "ŠK";//ŠK‘wXV
    }

    public void scene()
    {
        
        SceneManager.LoadScene("Result");
       
    }

    public void battle()
    {

        if (playerManager.SPD > enemyManeger.SPD)//‘‚¢‚Ù‚¤‚©‚çs“®
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
        int rad = Random.Range(0, 101);
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
        
            playerManager.PlayerLife = playerManager.PlayerLife - EnemyDamage;
            logManeger.Damage2();
        
    } 
}
    

