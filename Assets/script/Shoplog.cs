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
                item.text = "�̗͂�������֗��ȃn�[�g�@\n �ő�HP�@+ 3";
                break;
            case 1:
                item.text = "����b���Ă����@\n �U���́@+ 2";
                break;
            case 2:
                item.text = "�������y���Ȃ�C�@\n ���x�@+ 3";
                break;
            case 3:
                item.text = "����b���Ă����@\n �h��́@+ 3";
                break;
        }
    }
}
