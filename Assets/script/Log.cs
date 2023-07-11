using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Log : MonoBehaviour
{
    public DropedItemData D_Data;

    public Text MessageText;

    public Player playerManager;

    public Enemy enemyManager;

    public Item itemManager;

    public GameManager gameManeger;

    public EnemyGenerator enemygenerator;

    public bool isFrist = true;

    // Start is called before the first frame update
    public void Start()
    {
        MessageText.text = enemyManager.Enemyname + "が現れた";
        enemygenerator.isFirst = true;
    }

    public void Damage1()
    {
       MessageText.text = playerManager.playername + "は" + gameManeger.PlayerDamage + "ダメージを与えた";

    }

    public void Damage2()
    {
        MessageText.text = enemyManager.Enemyname + "は" + gameManeger.EnemyDamage + "ダメージを与えた";
    }

    public void GameEnd()
    {
        if(playerManager.PlayerLife == 0)
        {
            MessageText.text = playerManager.playername + "は負けてしまった";
            Invoke(nameof(scene), 2.0f);
        }
        else if(enemyManager.EnemyLife == 0)
        {
            MessageText.text = enemyManager.Enemyname + "は倒れた";
        }
    }

    public void Drop()
    {
        if (isFrist == true)
        {
            MessageText.text = enemyManager.Enemyname + "は" + itemManager.Itemname + "を落とした。";

            D_Data.DropedItemList.Add(itemManager.Itemname);

            isFrist = false;
        }
    }

    public void scene()
    {
        SceneManager.LoadScene("Result");
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
