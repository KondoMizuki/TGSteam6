using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InventoryManaget : MonoBehaviour
{
    int PossessionItem;

    public PlayerPossessionItemData P_Data;

    public Text PossessionItemText;

   

    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    public GameObject InventoryPanel;

    // Start is called before the first frame update
    void Start()
    {
        InventoryPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PossessionItem = P_Data.PlayerPossessionItemList.Count;

        if (PossessionItem == 0)
        {
            PossessionItemText.text = "�����i�͂���܂���";
        }
        else if (PossessionItem >= 1)
        {
            PossessionItemText.text = string.Join(",", P_Data.PlayerPossessionItemList);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            InventoryPanel.SetActive(!InventoryPanel.activeSelf);

        }
    }
        

   
}
