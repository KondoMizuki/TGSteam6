using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmManager : MonoBehaviour
{
    public Slider slider;
    public GameObject MuteBt;
    public GameObject VoluemBt;
    AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        slider.onValueChanged.AddListener(value => this.audioSource.volume = value);
    }

    void Update()
    {

    }

    public void VoluemButton()
    {
        VoluemBt.SetActive(false);
        MuteBt.SetActive(true);
        AudioListener.volume = 0f;
    }
    public void MuteButton()
    {
        MuteBt.SetActive(false);
        VoluemBt.SetActive(true);
        AudioListener.volume = 1f;
    }
}
