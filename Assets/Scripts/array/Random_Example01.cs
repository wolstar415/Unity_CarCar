using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Example01 : MonoBehaviour
{
    //
    public int minNum;
    public int maxNum;
    public int result;
    //    / Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            result = Random.Range(minNum, maxNum);
            print(result);
        }



    }

    //

}







