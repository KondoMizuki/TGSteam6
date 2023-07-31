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

    //インスペクターウィンドウからゲームオブジェクトを設定する
    public GameObject InventoryPanel;

    // Start is called before the first frame update
    void Start()
    {
        PossessionItemText.text = "所持品:" + "\n";

        InventoryPanel.SetActive(false);

        PossessionItem = P_Data.PlayerPossessionItemList.Count;

        if (PossessionItem == 0)
        {
            PossessionItemText.text = "所持品はありません";
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
                PossessionItemText.text += key + "×" + dic[key] + "\n";
            }
            //PossessionItemText.text = "所持品:" + string.Join(",", P_Data.PlayerPossessionItemList);
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
