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
                print("A형을 선택하셨습니다.");
                break;
            case 1:
                print("B형을 선택하셨습니다.");
                break;
            case 2:
                print("O형을 선택하셨습니다.");
                break;
            case 3:
                print("AB형을 선택하셨습니다.");
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
