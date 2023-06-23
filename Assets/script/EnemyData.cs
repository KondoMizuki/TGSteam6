using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/EnemyData")]

public class EnemyData : ScriptableObject   //ScriptableObject���p������
{
    public string id;          //�o�^ID

    public string Enemyname;//�L�����N�^�[�̖��O

    public int Life;//�̗�
    public int EnemyMaxLife;
    public int Attack;//�U����
    public int DFE;//�h���
    public int SPD;//�f����
}
