using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMONOFF : MonoBehaviour
{
    public Toggle t;
    public AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        t = GameObject.Find("Toggle").GetComponent<Toggle>();
        a = GameObject.Find("Player").GetComponent<AudioSource>();
        a.mute = t.isOn;
    }


    public void BGMonoff()
    {
        a.mute = t.isOn;
    }
}
