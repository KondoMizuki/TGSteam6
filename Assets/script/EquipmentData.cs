using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/EquipmentData")]

public class EquipmentData : ScriptableObject   //ScriptableObject���p������
{
    public string id;          //�o�^ID

    public string Item;

    public int MaxLife;//�̗͂𑝂₷
    public int Attack;//�U���͂𑝂₷
    public int DFE;//�h��͂𑝂₷
    public int SPD;//�f�����𑝂₷
    public int BuyGold;//�������߂̋�
}
