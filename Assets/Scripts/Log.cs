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
        MessageText.text = enemyManager.Enemyname + "�����ꂽ";


    }

    public void Damage1()
    {
       MessageText.text = playerManager.playername + "��" + gameManeger.PlayerDamage + "�_���[�W��^����";

    }

    public void Damage2()
    {
        MessageText.text = enemyManager.Enemyname + "��" + gameManeger.EnemyDamage + "�_���[�W��^����";
    }

    void GameEnd()
    {
        if(playerManager.PlayerLife == 0)
        {
            MessageText.text = playerManager.playername + "�͕����Ă��܂���";
        }
        else
            if(enemyManager.EnemyLife == 0)
        {
            MessageText.text = enemyManager.Enemyname + "�͓|�ꂽ";
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
