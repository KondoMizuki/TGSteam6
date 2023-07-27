using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player playerManager;

    public Enemy enemyManeger;

    public Item itemManager;

    public Log logManeger;

    public int PlayerDamage;

    public int EnemyDamage;

    public float _repeatSpan;

    public float _timeElaped;

    public int stage = 1;

    public static int endstage = 1;

    public bool isAttack = false;
    public bool isNext = false;
    public bool isHurt = false;

    public Text FloorText;

    public Text EndFloorText;

    // Start is called before the first frame update
    public void Start()
    {
        
        _repeatSpan = 4;//�s�����s����܂ł̎���
        _timeElaped = 2;//�����̍s���܂ł̂��
        FloorText.text = "���� " + stage + "�K";//���݂̊K�w
        EndFloorText.text = "�ŏ�K " + endstage + "�K";//�I�_
    }

    // Update is called once per frame
    void Update()
    {
        _timeElaped += Time.deltaTime;
        if (playerManager.PlayerLife > 0 | enemyManeger.EnemyLife > 0)
        {
            if (_timeElaped >= _repeatSpan)//_repeatSpan��_timeElaped�ȏ�ɂȂ�����o�g��������
            {
                battle();
                _timeElaped = 0;//���Ԃ��O�ɂ���
                logManeger.isFrist = true;
            }
        }

        if (enemyManeger.EnemyLife < 0)//�̗͂�0�ȉ��ɂȂ�Ȃ�
        {
            enemyManeger.EnemyLife = 0;
        }

        if (playerManager.PlayerLife < 0)
        {
            playerManager.PlayerLife = 0;
        }

        if (playerManager.PlayerLife > playerManager.MaxLife)
        {
            playerManager.PlayerLife = playerManager.MaxLife;
        }

        
    }

    public void NextStage()
    {
        if (playerManager.PlayerLife > 0 && enemyManeger.EnemyLife == 0)//�v���C���[�������ĂēG�����񂾏ꍇ
        {
            int Ransu = Random.Range(1, 101);
            if (itemManager.Dropprobability >= Ransu)
            {
                Invoke(nameof(Drop), 1.0f);
            }

            if (stage == endstage)//�I�_�ƌ��݂̃X�e�[�W�������ꍇ�I���Ⴄ�ꍇ����
            {
                logManeger.GameEnd();
                enemyManeger.EnemyLife = enemyManeger.EnemyMaxLife;//�̗͉�
                endstage = endstage + 1;//�K�w�ǉ�
                isNext = true;
                Invoke(nameof(scene), 2.0f);
            }
            else
            {
                logManeger.GameEnd();
                enemyManeger.EnemyLife = enemyManeger.EnemyMaxLife;//����
                stage = stage + 1;
                isNext = true;
                Invoke(nameof(Endlog), 2.0f);
            }
        }
    }


    public void Drop()
    {
        logManeger.Drop();
    }


    public void Endlog()
    {
        enemyManeger.Start();
        itemManager.Start();
        logManeger.Start();
        playerManager.PlayerLife = playerManager.PlayerLife + 20; //��
        _timeElaped = 0;//���Ԃ��O�ɂ���
        FloorText.text = "���� " + stage + "�K";//�K�w�X�V
        isNext = false;
    }

    public void scene()
    {
        
        SceneManager.LoadScene("Result");
        isNext = false;
    }

    public void battle()
    {

        if (playerManager.SPD > enemyManeger.SPD)//�����ق�����s��
        {
            if (playerManager.PlayerLife > 0 && enemyManeger.EnemyLife > 0)
            {
                player();
                Invoke(nameof(NextStage), 1.0f);
            }
               
            if (enemyManeger.EnemyLife > 0 && playerManager.PlayerLife > 0)
            {
                
                Invoke(nameof(Enemy), 2.0f);
                Invoke(nameof(NextStage), 3.0f);
            }
               
        }
        else
        {
            if (enemyManeger.EnemyLife > 0 && playerManager.PlayerLife > 0)
            {
                
                Invoke(nameof(Enemy), 1.0f);
                NextStage();

            }
            if (playerManager.PlayerLife > 0 && enemyManeger.EnemyLife > 0)
            {
                Invoke(nameof(player), 2.0f);
                Invoke(nameof(NextStage), 3.0f);

            }
               
        }
    }

    void player()
    {
        int rad = Random.Range(0, 101);//�N���e�B�J��
        if (rad >= 95)
        {
            PlayerDamage = playerManager.PlayerAttack * 2;
        }
        else
        {
            PlayerDamage = playerManager.PlayerAttack - enemyManeger.DFE;
            if(PlayerDamage < 0)
            {
                PlayerDamage = 0;
            }
        }
        isAttack = true;
        enemyManeger.EnemyLife = enemyManeger.EnemyLife - PlayerDamage;
        logManeger.Damage1();
    }

    void Enemy()
    {
        EnemyDamage = enemyManeger.Attack - playerManager.DFE;
        
        playerManager.PlayerLife = playerManager.PlayerLife - EnemyDamage;
        logManeger.Damage2();

        isHurt = true;
    } 
}
    

