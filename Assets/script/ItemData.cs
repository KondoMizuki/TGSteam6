using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/ItemData")]

public class ItemData : ScriptableObject   //ScriptableObjectÇåpè≥Ç∑ÇÈ
{
    public string id;          //ìoò^ID

    public string Itemname;

    public int Dropprobability;
    public int SellingPrice;
}
