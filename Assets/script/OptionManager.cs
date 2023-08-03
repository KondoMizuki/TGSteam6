using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    public GameObject OptionPanel;

    // Start is called before the first frame update
    void Start()
    {
        OptionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionPanel.SetActive(!OptionPanel.activeSelf);
        }
    }
}
