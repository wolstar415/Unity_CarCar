using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame updatesdasd

    public void buttonStart()
    {
        
        SceneManager.LoadScene(1);

     


    }
    public void buttonExit()
    {
        Application.Quit();

    }


    
  }