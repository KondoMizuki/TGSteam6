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
    public Enemys enemy6;
    public Enemys enemy7;
    public Enemys enemy8;
    public Enemys enemy9;
    public Enemys enemy10;

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
            Enemys enemycopy = Instantiate<Enemys>(enemy1);
            isFirst = false;
        }
        else if(gamemanager.stage == 2 && isFirst == true)
        {
            Enemys enemycopy = Instantiate<Enemys>(enemy2);
            isFirst = false;
        }
        else if (gamemanager.stage == 3 && isFirst == true)
        {
            Enemys enemycopy = Instantiate<Enemys>(enemy3);
            isFirst = false;
        }
        else if (gamemanager.stage == 4 && isFirst == true)
        {
            Enemys enemycopy = Instantiate<Enemys>(enemy4);
            isFirst = false;
        }
        else if (gamemanager.stage == 5 && isFirst == true)
        {
            Enemys enemycopy = Instantiate<Enemys>(enemy5);
            isFirst = false;
        }
        else if (gamemanager.stage == 6 && isFirst == true)
        {
            Enemys enemycopy = Instantiate<Enemys>(enemy6);
            isFirst = false;
        }
        else if (gamemanager.stage == 7 && isFirst == true)
        {
            Enemys enemycopy = Instantiate<Enemys>(enemy7);
            isFirst = false;
        }
        else if (gamemanager.stage == 8 && isFirst == true)
        {
            Enemys enemycopy = Instantiate<Enemys>(enemy8);
            isFirst = false;
        }
        else if (gamemanager.stage == 9 && isFirst == true)
        {
            Enemys enemycopy = Instantiate<Enemys>(enemy9);
            isFirst = false;
        }
        else if (gamemanager.stage == 10 && isFirst == true)
        {
            Enemys enemycopy = Instantiate<Enemys>(enemy10);
            isFirst = false;
        }
    }
}
