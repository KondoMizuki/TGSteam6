using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shoplog : MonoBehaviour
{
    public Text item;
    public Shop shop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (shop.count)
        {
            case 0:
                item.text = "体力が増える便利なハート　\n 最大HP　+ 3";
                break;
            case 1:
                item.text = "剣を鍛えてくれる　\n 攻撃力　+ 2";
                break;
            case 2:
                item.text = "動きが軽くなる靴　\n 速度　+ 3";
                break;
            case 3:
                item.text = "盾を鍛えてくれる　\n 防御力　+ 3";
                break;
        }
    }
}
