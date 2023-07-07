using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(menuName = "ScriptableObject/DropedItemData")]

public class DropedItemData : ScriptableObject   //ScriptableObjectÇåpè≥Ç∑ÇÈ
{
    public List<string> DropedItemList = new List<string>();
}
