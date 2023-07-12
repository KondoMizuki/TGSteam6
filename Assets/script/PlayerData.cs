using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/PlayerData")]

public class PlayerData : ScriptableObject   //ScriptableObject‚ğŒp³‚·‚é
{
    public string id;          //“o˜^ID

    public string Playername;//ƒLƒƒƒ‰ƒNƒ^[‚Ì–¼‘O

    public int Life;//‘Ì—Í
    public int PlayerMaxLife;
    public int Attack;//UŒ‚—Í
    public int DFE;//–hŒä—Í
    public int SPD;//‘f‘‚³
}
