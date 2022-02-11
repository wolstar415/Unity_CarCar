using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Example02 : MonoBehaviour
{
    public int criPer;
    public int randomResult;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CriAttack();
        }

    }
    public void CriAttack()
    {
        randomResult = Random.Range(0, 100);

        if (randomResult < criPer)
        {
            print(randomResult);
            print("Critical");

        }
        else
        {
            print(randomResult);
            print("nomal");

        }

    }

}
