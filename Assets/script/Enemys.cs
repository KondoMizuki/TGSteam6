using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    public GameManager gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if($"{name}" == "Boneworm(Clone)")
        {
            if(gamemanager.stage != 1)
            {
                Destroy(this.gameObject);
            }
        }
        else if ($"{name}" == "Slime(Clone)")
        {
            if (gamemanager.stage != 2)
            {
                Destroy(this.gameObject);
            }
        }
        else if ($"{name}" == "Skull(Clone)")
        {
            if (gamemanager.stage != 3)
            {
                Destroy(this.gameObject);
            }
        }
        else if ($"{name}" == "Cerberus(Clone)")
        {
            if (gamemanager.stage != 4)
            {
                Destroy(this.gameObject);
            }
        }
        else if ($"{name}" == "Spider(Clone)")
        {
            if (gamemanager.stage != 5)
            {
                Destroy(this.gameObject);
            }
        }
        else if ($"{name}" == "Wolf(Clone)")
        {
            if (gamemanager.stage != 6)
            {
                Destroy(this.gameObject);
            }
        }
        else if ($"{name}" == "Scorpion(Clone)")
        {
            if (gamemanager.stage != 7)
            {
                Destroy(this.gameObject);
            }
        }
        else if ($"{name}" == "Worm(Clone)")
        {
            if (gamemanager.stage != 8)
            {
                Destroy(this.gameObject);
            }
        }
        else if ($"{name}" == "Rat(Clone)")
        {
            if (gamemanager.stage != 9)
            {
                Destroy(this.gameObject);
            }
        }
        else if ($"{name}" == "Ooze(Clone)")
        {
            if (gamemanager.stage != 10)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
