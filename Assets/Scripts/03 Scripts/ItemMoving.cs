using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemMoving : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, -speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Wall")
        {
        Destroy(gameObject);

        }
        /*
        if (other.gameObject.name == "Player" && (gameObject.tag == "Clock"))
        {
            check.score = check.score + 100;
            check.TextReset();
            Destroy(gameObject);

        }
        else if (other.gameObject.name == "Player" && (gameObject.tag == "Star"))
        {
            //print(gameObject.name);
            check.score = check.score + 3;
            check.TextReset();
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Player" && (gameObject.tag == "Heart"))
        {
            check.score = check.score + 10;
            check.TextReset();
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Player" && (gameObject.tag == "Coin"))
        {
            check.score = check.score + 1;
            check.TextReset();
            Destroy(gameObject);
        }
        */
    }
}
