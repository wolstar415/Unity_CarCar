using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnemyCreate : MonoBehaviour
{
    // Start is called before the first frame update

    float dealtime;
    public float cooltimemax;
    public float cooltimemin;
    public Object enemy;
    public Object[] enemy1;
    public Object[] Items;
    float cooltime;
    //public GameManager GameMa;

    void Start()
    {
        //cooltime = Random.Range(cooltimemin, cooltimemax);
        RandomCoolTime();
    }

    // Update is called once per frame
    void Update()
    {
        
        dealtime += Time.deltaTime;

        if (dealtime >= cooltime)
        {
            //cooltime = Random.Range(cooltimemin, cooltimemax);
            RandomCoolTime();
            dealtime = 0;
            int lotto = Random.Range(0, 100);
            //if (GameObject.Find("Player").transform.position.z > 0)
            //{
                
            //    lotto = 100;
                
                
            //}
            GameManager check = GameObject.Find("GameManager").GetComponent<GameManager>();
            if (check.boosterOnOFF == true)
            {
                lotto = 99;
                
            }
                if (lotto >= 25 )

            {
                MakeEnemy();
            }
                      else
            {
                MakeItem();


            }
            // Instantiate(enemy, transform.position, transform.rotation);
        }
    }

    public void RandomCoolTime()
    {
        cooltime = Random.Range(cooltimemin, cooltimemax);
    }

    void MakeEnemy()
    {
        
        Instantiate(enemy1[Random.Range(0, enemy1.Length - 1)], transform.position, transform.rotation);
    }

    void MakeItem()
    {
        int i = 1;
        int lotto = Random.Range(0, 100);
        if (lotto <= 5)
        
        {
            i = 0;
        }
        else if (5 < lotto && lotto <= 11 )
        {
            i = 2;
        }

        else if (11 < lotto && lotto < 50)
        {

            i = 3;
        }
        else
        {

            i = 1;
        }
        Instantiate(Items[i], transform.position, transform.rotation);
        //Instantiate(Items[Random.Range(0, Items.Length - 1)], transform.position, transform.rotation);
        cooltime = Random.Range(cooltimemin * 0.7f, cooltimemax * 0.7f);
    }
}
