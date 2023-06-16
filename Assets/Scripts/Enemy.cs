using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    public int EnemyLife = 5;

    public int Attack = 7;

    public int DFE = 3;

    public int SPD = 1;

   

    //public Text EnemyLifeText;

    public string Enemyname;


    // Start is called before the first frame update
    void Awake()
    {
        Enemyname = "‚·‚ç‚ç";
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}