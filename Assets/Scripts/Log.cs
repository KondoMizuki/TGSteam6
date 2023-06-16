using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Log : MonoBehaviour
{
    public Text MessageText;

    public Player playerManager;

    public Enemy enemyManager;

    public GameManager gameManeger;

    // Start is called before the first frame update
    void Start()
    {
        MessageText.text = enemyManager.Enemyname + "が現れた";


    }

    public void Damage1()
    {
       MessageText.text = playerManager.playername + "は" + gameManeger.PlayerDamage + "ダメージを与えた";

    }

    public void Damage2()
    {
        MessageText.text = enemyManager.Enemyname + "は" + gameManeger.EnemyDamage + "ダメージを与えた";
    }

    void GameEnd()
    {
        if(playerManager.PlayerLife == 0)
        {
            MessageText.text = playerManager.playername + "は負けてしまった";
        }
        else
            if(enemyManager.EnemyLife == 0)
        {
            MessageText.text = enemyManager.Enemyname + "は倒れた";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerManager.PlayerLife == 0 | enemyManager.EnemyLife == 0)
        {
            Invoke(nameof(GameEnd), 2.0f);
        }
    }
}
