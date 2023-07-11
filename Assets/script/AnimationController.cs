using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameManager gamemanager;
    public Log logmanager;

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

        if(gamemanager.isAttack == false && logmanager.isDeath == false)
        {
            trans = 0;
        }
        else if(gamemanager.isAttack == true && logmanager.isDeath == false)
        {
            trans = 1;
            gamemanager.isAttack = false;
        }
        else if(gamemanager.isAttack == false && logmanager.isDeath == true)
        {
            trans = 2;
            logmanager.isDeath = false;
        }

        //intパラメーターの値を設定する.
        animator.SetInteger("trans", trans);
    }
}
