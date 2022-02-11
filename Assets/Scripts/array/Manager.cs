using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public float curTime;
    public float coolTime;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
if (curTime > coolTime)
        {
            MakeEnemy();
            curTime = 0;
        }
    }

    void MakeEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);

    }
}
