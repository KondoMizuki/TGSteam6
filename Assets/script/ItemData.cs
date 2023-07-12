using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/ItemData")]

public class ItemData : ScriptableObject   //ScriptableObject���p������
{
    public string id;          //�o�^ID

    public string Itemname;

    public int Dropprobability;
    public int SellingPrice;
}
