using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class streetMoving : MonoBehaviour
{

    public float speed;
    float orix;
    // Start is called before the first frame update
    void Start()
    {

     }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    if (transform.position.z < -100)
        {
            transform.position=(new Vector3(transform.position.x, transform.position.y, 80));
            print("asd");


        }
    }
}
