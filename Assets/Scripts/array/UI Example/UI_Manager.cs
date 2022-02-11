using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public Toggle bgmToggle;
    public Slider bgmslider;
    public Dropdown bloodTypeBar;
    public Toggle passcheckz;
    public InputField passwordbox;
    


    // Start is called before the first frame update
    void Start()
    {
        bgmAudioSource = GameObject.Find("BGM").GetComponent<AudioSource>();
        bgmToggle = GameObject.Find("Toggle").GetComponent<Toggle>();
        bgmslider = GameObject.Find("BGMSlider").GetComponent<Slider>();
        bloodTypeBar = GameObject.Find("Dropdown").GetComponent<Dropdown>();
        passcheckz = GameObject.Find("Toggle2").GetComponent<Toggle>();
        passwordbox = GameObject.Find("InputField_PW").GetComponent<InputField>();



        bgmAudioSource.mute = bgmToggle.isOn;
        bgmAudioSource.volume = bgmslider.value;
    }

    // Update is called once per frame
    void Update()
    {
        //BGMOnOFF();
    }

    public void BGMOnOFF()
    {
        bgmAudioSource.mute = bgmToggle.isOn;
    }
    public void ChangeBGMVolume()
    {
        bgmAudioSource.volume = bgmslider.value;
    }

    public void SelectBloodType()
    {
        int selectedNum = bloodTypeBar.value;
        
        switch (selectedNum)
        {
            case 0:
                print("A���� �����ϼ̽��ϴ�.");
                break;
            case 1:
                print("B���� �����ϼ̽��ϴ�.");
                break;
            case 2:
                print("O���� �����ϼ̽��ϴ�.");
                break;
            case 3:
                print("AB���� �����ϼ̽��ϴ�.");
                break;

            default:
                break;
        }
    }

    public void passcheck()
    {
        if (passcheckz.isOn == true)
        {
            passwordbox.contentType = InputField.ContentType.Standard;
        }
        else
        {
            passwordbox.contentType = InputField.ContentType.Password;
        }
    }
}
