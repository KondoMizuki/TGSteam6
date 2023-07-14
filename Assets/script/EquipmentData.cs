using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/EquipmentData")]

public class EquipmentData : ScriptableObject   //ScriptableObject‚ğŒp³‚·‚é
{
    public string id;          //“o˜^ID

    public string Item;

    public int MaxLife;//‘Ì—Í‚ğ‘‚â‚·
    public int Attack;//UŒ‚—Í‚ğ‘‚â‚·
    public int DFE;//–hŒä—Í‚ğ‘‚â‚·
    public int SPD;//‘f‘‚³‚ğ‘‚â‚·
    public int BuyGold;//”ƒ‚¤‚½‚ß‚Ì‹à
}
