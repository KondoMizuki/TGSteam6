using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public DropedItemData D_Data;
    public PlayerPossessionItemData P_Data;

    public Text DropedItemText;

    // Start is called before the first frame update
    void Start()
    {
        P_Data.PlayerPossessionItemList.AddRange(D_Data.DropedItemList);

        P_Data.PlayerPossessionItemList.Sort();

        //D_Data.DropedItemList.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        if (P_Data.PlayerPossessionItemList.Count > 0)
        {
            DropedItemText.text = "�험�i:" + string.Join(",", D_Data.DropedItemList);
        }
        else if (P_Data.PlayerPossessionItemList.Count == 0)
        {
            DropedItemText.text = "����̐퓬�ł͐험�i�͂���܂���ł����B";
        }
    }
}
