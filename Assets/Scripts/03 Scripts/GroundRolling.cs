using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRolling : MonoBehaviour
{
    // Start is called before the first frame updatd

    public Vector3 originPos;
    public float speed;
    public float limitz;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -speed*Time.deltaTime);
        if (transform.position.z < limitz)
        {
            //transform.position = originPos;
            transform.Translate(0, 0, +453.7f);
        }
    }
}
