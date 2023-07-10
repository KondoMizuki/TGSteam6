using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InventoryManaget : MonoBehaviour
{
    public PlayerPossessionItemData P_Data;

    public Text PossessionItemText;

    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    public GameObject InventoryPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PossessionItemText.text = string.Join(",", P_Data.PlayerPossessionItemList);
    }

    public void PanelBt()
    {
        InventoryPanel.SetActive(true);
    }

    public void ExitBt()
    {
        InventoryPanel.SetActive(false);
    }
}
