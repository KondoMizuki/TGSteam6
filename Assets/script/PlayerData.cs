using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/PlayerData")]

public class PlayerData : ScriptableObject   //ScriptableObject���p������
{
    public string id;          //�o�^ID

    public string Playername;//�L�����N�^�[�̖��O

    public int Life;//�̗�
    public int PlayerMaxLife;
    public int Attack;//�U����
    public int DFE;//�h���
    public int SPD;//�f����
}
