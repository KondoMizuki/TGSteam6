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
        PossessionItemText.text = "�����i:" + "\n";

        InventoryPanel.SetActive(false);

        PossessionItem = P_Data.PlayerPossessionItemList.Count;

        if (PossessionItem == 0)
        {
            PossessionItemText.text = "�����i�͂���܂���";
        }
        else if (PossessionItem >= 1)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string key in P_Data.PlayerPossessionItemList)
            {
                if (dic.ContainsKey(key))
                {
                    dic[key]++;
                }
                else
                {
                    dic.Add(key, 1);
                }
            }
            foreach (string key in dic.Keys)
            {
                PossessionItemText.text += key + "�~" + dic[key] + "\n";
            }
            //PossessionItemText.text = "�����i:" + string.Join(",", P_Data.PlayerPossessionItemList);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InventoryPanel.SetActive(!InventoryPanel.activeSelf);
        }
    }
}
