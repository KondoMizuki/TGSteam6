using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(menuName = "ScriptableObject/PlayerPossessionItemData")]

public class PlayerPossessionItemData : ScriptableObject   //ScriptableObject���p������
{
    public List<string> PlayerPossessionItemList = new List<string>();
}
