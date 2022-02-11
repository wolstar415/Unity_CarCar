using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public float movespeed;
    public float limit;
    public GameObject[] effects;
    public GameManager GameMa;
    float startspeed;
    public bool checkL = false;
    public bool checkR = false;

    
    // Start is called before the first frame update
    void Start()

    {
        startspeed = movespeed;
    }
    public void DownL()
    {
        checkL = true;
    }
    public void UpL()
    {
        checkL = false;
    }
    public void DownR()
    {
        checkR = true;
    }
    public void UpR()
    {
        checkR = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMa.boosterOnOFF == true)
        {
            movespeed = startspeed * 1.5f;
        }
        else
        {
            movespeed = startspeed;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || checkL)
        {
            transform.Translate(-movespeed*Time.deltaTime,0,0);
        }

        if (Input.GetKey(KeyCode.RightArrow) || checkR)
        {
            transform.Translate(movespeed * Time.deltaTime, 0, 0);
        }

        if (transform.position.x <-limit)
        {
            transform.position = new Vector3(-limit, transform.position.y, transform.position.z);

        }
        if (transform.position.x > limit)
        {
            transform.position = new Vector3(limit, transform.position.y, transform.position.z);

        }


      //  transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Enemy":

                if (GameMa.boosterOnOFF == true)
                {
                    Destroy(other.gameObject);
                    Destroy(Instantiate(effects[0], other.transform.position, other.transform.rotation), 1f);

                    if (other.gameObject.name == "enemy2(Clone)")
                    {
                        GameMa.PlusScore(3);
                    }
                    else
                    {
                        GameMa.PlusScore(1);
                    }
                    
                    //GameMa.PlusTime(1f);
                    //GameMa.MinusHeart();
                    //GameMa.PlusBooster(1);

                }
                else
                {
                    
                    //print(other.gameObject.tag);
                    Destroy(other.gameObject);
                    Destroy(Instantiate(effects[0], other.transform.position, other.transform.rotation), 1f);
                    if (GameMa.isDamaged == false && transform.position.z <= 0)
                    {

                    GameMa.MinusHeart();
                    }
                    GameMa.isDamaged = true;
                    //GameMa.PlusBooster(1);
                }
                
                break;
            case "Coin":

                GameMa.PlusScore(1);
                GameMa.PlusBooster(3);
                Destroy(Instantiate(effects[1], other.transform.position, other.transform.rotation), 1f);
                Destroy(other.gameObject);
                break;
            case "Star":
                GameMa.PlusScore(3);
                GameMa.PlusBooster(6);
                Destroy(Instantiate(effects[2], other.transform.position, other.transform.rotation), 1f);
                Destroy(other.gameObject);
                break;
            case "Heart":
                //print(other.gameObject.tag);
                Destroy(other.gameObject);
                Destroy(Instantiate(effects[3], other.transform.position, other.transform.rotation), 1f);
                GameMa.PlusHeart();
                break;

            case "Clock":
                //print(other.gameObject.tag);
                Destroy(other.gameObject);
                Destroy(Instantiate(effects[4], other.transform.position, other.transform.rotation), 1f);
                GameMa.PlusTime(10f);
                GameMa.PlusBooster(1);
                break;
            default:
                break;
        }


        //if(other.gameObject.tag ==)
    }
}
