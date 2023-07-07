using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(menuName = "ScriptableObject/DropedItemData")]

public class DropedItemData : ScriptableObject   //ScriptableObject���p������
{
    public List<string> DropedItemList = new List<string>();
}
