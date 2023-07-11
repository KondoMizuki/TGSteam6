using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public DropedItemData D_Data;

    public int PlayerLife = 15;

    public int MaxLife = 15;

    public int PlayerAttack = 5;

    public int DFE = 5;

    public int SPD = 5;

    public Text NameText;

    public Text PlayerLifeText;

    public string playername;

    // Start is called before the first frame update
    void Start()
    {
        NameText.text = "�v���C���[";
        playername = "�v���C���[";

        D_Data.DropedItemList.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerLifeText.text = "�̗� " + PlayerLife;
    
    }
}
