using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/EquipmentData")]

public class EquipmentData : ScriptableObject   //ScriptableObjectを継承する
{
    public string id;          //登録ID

    public string Item;

    public int MaxLife;//体力を増やす
    public int Attack;//攻撃力を増やす
    public int DFE;//防御力を増やす
    public int SPD;//素早さを増やす
    public int BuyGold;//買うための金
}
