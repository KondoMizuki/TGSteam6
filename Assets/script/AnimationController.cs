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
        //GetComponent��p����Animator�R���|�[�l���g�����o��.
        Animator animator = GetComponent<Animator>();

        //���炩���ߐݒ肵�Ă���int�p�����[�^�[�utrans�v�̒l�����o��.
        int trans = animator.GetInteger("trans");

        Debug.Log(trans);
        Debug.Log(gamemanager.isNext);

        if (gamemanager.isAttack == false && logmanager.isDeath == false && gamemanager.isNext == false)
        {
            trans = 0;
        }
        else if(logmanager.isDeath == false && gamemanager.isAttack == true && gamemanager.isNext == false) 
        {
            trans = 1;
            gamemanager.isAttack = false;
        }
        else if(logmanager.isDeath == true)
        {
            trans = 2;
        }else if(gamemanager.isNext == true)
        {
            trans = 3;
            //gamemanager.isNext = false;
            Debug.Log(gamemanager.isNext);
        }

        //int�p�����[�^�[�̒l��ݒ肷��.
        animator.SetInteger("trans", trans);
    }
}
