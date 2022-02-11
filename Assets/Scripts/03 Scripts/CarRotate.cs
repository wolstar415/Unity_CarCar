using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotate : MonoBehaviour
{
    public static bool check;
    public float rotationangle;

    public PlayerMoving fuplayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.LeftArrow) || fuplayer.checkL)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, -rotationangle, 0));
            check = true;
        }

        else if (Input.GetKey(KeyCode.RightArrow) || fuplayer.checkR)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, rotationangle, 0));
            check = true;
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            check = false;
        }
    }
}
