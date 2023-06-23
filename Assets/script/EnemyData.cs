using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/EnemyData")]

public class EnemyData : ScriptableObject   //ScriptableObject‚ğŒp³‚·‚é
{
    public string id;          //“o˜^ID

    public string Enemyname;//ƒLƒƒƒ‰ƒNƒ^[‚Ì–¼‘O

    public int Life;//‘Ì—Í
    public int EnemyMaxLife;
    public int Attack;//UŒ‚—Í
    public int DFE;//–hŒä—Í
    public int SPD;//‘f‘‚³
}
