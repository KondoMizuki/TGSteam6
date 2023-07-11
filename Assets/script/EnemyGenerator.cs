using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameManager gamemanager;

    public Enemys enemy1;
    public Enemys enemy2;
    public Enemys enemy3;
    public Enemys enemy4;
    public Enemys enemy5;

    public bool isFirst = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gamemanager.stage == 1 && isFirst == true)
        {
            Enemys enemycopy1 = Instantiate<Enemys>(enemy1);
            isFirst = false;
        }else if(gamemanager.stage == 2 && isFirst == true)
        {
            Enemys enemycopy2 = Instantiate<Enemys>(enemy2);
            isFirst = false;
        }
        else if (gamemanager.stage == 3 && isFirst == true)
        {
            Enemys enemycopy3 = Instantiate<Enemys>(enemy3);
            isFirst = false;
        }
        else if (gamemanager.stage == 4 && isFirst == true)
        {
            Enemys enemycopy4 = Instantiate<Enemys>(enemy4);
            isFirst = false;
        }
        else if (gamemanager.stage == 5 && isFirst == true)
        {
            Enemys enemycopy5 = Instantiate<Enemys>(enemy5);
            isFirst = false;
        }
    }
}
