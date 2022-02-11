using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{

    public int[] myarray;
    // Start is called before the first frame update
    void Start()
    {
        myarray = new int[10];
        for (int i = 0; i < 100; i++)
        {
            myarray[i] = i + 1;
        }
            
            }

    // Update is called once per frame
    void Update()
    {
        
    }
}
