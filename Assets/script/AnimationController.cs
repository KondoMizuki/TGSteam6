using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameManager gamemanager;
    public Log logmanager;
    public float endTime = 1.2f;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponentを用いてAnimatorコンポーネントを取り出す.
        Animator animator = GetComponent<Animator>();

        //あらかじめ設定していたintパラメーター「trans」の値を取り出す.
        int trans = animator.GetInteger("trans");

        if (!gamemanager.isAttack && !logmanager.isDeath && !gamemanager.isNext && !gamemanager.isHurt)
        {
            trans = 0;
        }
        else if(!logmanager.isDeath && gamemanager.isAttack && !gamemanager.isNext && !gamemanager.isHurt) 
        {
            trans = 1;
            gamemanager.isAttack = false;
        }
        else if(logmanager.isDeath)
        {
            trans = 2;
        }else if(gamemanager.isNext)
        {
            trans = 3;
        }else if(gamemanager.isHurt)
        {
            trans = 4;
            gamemanager.isHurt = false;
        }

        //intパラメーターの値を設定する.
        animator.SetInteger("trans", trans);
    }
}
