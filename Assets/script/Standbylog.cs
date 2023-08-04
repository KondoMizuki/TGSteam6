using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Standbylog : MonoBehaviour
{
    public Player player;
    public Text message;
    public Text HP;
    public Text ATK;
    public Text DFE;
    public Text SPD;
    public Text G;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HP.text = player.MaxLife.ToString();
        ATK.text =player.PlayerAttack.ToString();
        SPD.text = player.SPD.ToString();
        DFE.text = player.DFE.ToString();
        G.text = player.GOLD.ToString();
        message.text = "åªç›ÇÃç≈è„äKÇÕ" + GameManager.endstage + "äK";

    }
}
