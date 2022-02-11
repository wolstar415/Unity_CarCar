using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMoving : MonoBehaviour
{

    public float speed;
    float orix;
    // Start is called before the first frame update
    void Start()
    {
        orix = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    if (transform.position.z < orix - 130)
        {
            transform.position=(new Vector3(transform.position.x, transform.position.y, 60));

        }
    }
}
