using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameManager gamemanager;

    public ItemData I_Data;
    public ItemData I_Data2;
    public ItemData I_Data3;
    public ItemData I_Data4;
    public ItemData I_Data5;

    public int SellingPrice1;
    public int SellingPrice2;
    public int SellingPrice3;
    public int SellingPrice4;
    public int SellingPrice5;

    public string id;          //“o˜^ID

    public string Itemname;

    public float Dropprobability;

    // Start is called before the first frame update
    public void Start()
    {
        switch (gamemanager.stage)
        {
            case 1:
                id = I_Data.id;
                Itemname = I_Data.Itemname;
                Dropprobability = I_Data.Dropprobability;
                break;

            case 2:
                id = I_Data2.id;
                Itemname = I_Data2.Itemname;
                Dropprobability = I_Data2.Dropprobability;
                break;

            case 3:
                id = I_Data3.id;
                Itemname = I_Data3.Itemname;
                Dropprobability = I_Data3.Dropprobability;
                break;

            case 4:
                id = I_Data4.id;
                Itemname = I_Data4.Itemname;
                Dropprobability = I_Data4.Dropprobability;
                break;

            case 5:
                id = I_Data5.id;
                Itemname = I_Data5.Itemname;
                Dropprobability = I_Data5.Dropprobability;
                break;
        }

        SellingPrice1 = I_Data.SellingPrice;
        SellingPrice2 = I_Data2.SellingPrice;
        SellingPrice3 = I_Data3.SellingPrice;
        SellingPrice4 = I_Data4.SellingPrice;
        SellingPrice5 = I_Data5.SellingPrice;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
