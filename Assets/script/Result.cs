using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class Result : MonoBehaviour
{
    public DropedItemData D_Data;
    public PlayerPossessionItemData P_Data;

    public Text DropedItemText;

    // Start is called before the first frame update
    void Start()
    {
        P_Data.PlayerPossessionItemList.AddRange(D_Data.DropedItemList);

        //P_Data.PlayerPossessionItemList.Sort();

        //D_Data.DropedItemList.Clear();

        //ダーティとしてマークする(変更があった事を記録する)
        EditorUtility.SetDirty(P_Data);

        //保存する
        AssetDatabase.SaveAssets();
    }

    // Update is called once per frame
    void Update()
    {
        if (D_Data.DropedItemList.Count > 0)
        {
            DropedItemText.text = "戦利品\n" + string.Join(",", D_Data.DropedItemList) + "\n";
        }
        else if (D_Data.DropedItemList.Count == 0)
        {
            DropedItemText.text = "今回の戦闘では戦利品の獲得ははありませんでした。";
        }
    }
}
