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
        DropedItemText.text = "êÌóòïi:" + string.Join(",", D_Data.DropedItemList);

        P_Data.PlayerPossessionItemList.AddRange(D_Data.DropedItemList);

        P_Data.PlayerPossessionItemList.Sort();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
