using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/EnemyData")]

public class EnemyData : ScriptableObject   //ScriptableObject���p������
{
    public string id;          //�o�^ID

    public string Enemyname;//�L�����N�^�[�̖��O

    public int EnemyLife;//�̗�
    public int EnemyMaxLife;
    public int Attack;//�U����
    public int DFE;//�h���
    public int SPD;//�f����

    public string getEnemyname()
    {
        return Enemyname;
    }

    public int getEnemyLife()
    {
        return EnemyLife;
    }
    public int getEnemyMaxLife()
    {
        return EnemyMaxLife;
    }
    public int getAttack()
    {
        return Attack;
    }
    public int getDFE()
    {
        return DFE;
    }
    public int getSPD()
    {
        return SPD;
    }
}
