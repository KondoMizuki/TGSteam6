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
        //GetComponent��p����Animator�R���|�[�l���g�����o��.
        Animator animator = GetComponent<Animator>();

        //���炩���ߐݒ肵�Ă���int�p�����[�^�[�utrans�v�̒l�����o��.
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

        //int�p�����[�^�[�̒l��ݒ肷��.
        animator.SetInteger("trans", trans);
    }
}
