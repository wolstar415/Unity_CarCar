using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class logo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("startgo", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void startgo()
    {
        print("start");

        SceneManager.LoadScene(1);

    }

}
