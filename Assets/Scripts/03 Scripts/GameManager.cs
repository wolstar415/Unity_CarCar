using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float LimitTime;

    public GameObject effect;
    public GameObject level_two;
    public GameObject level_three;
    public GameObject level_Booster;
    public int score;
    public GameObject Textscore;
    public GameObject gameovertext;
    public GameObject BoosterObject;
    public GameObject Player;
    public Slider HpBar;
    public Slider BoosterBar;
    public int hp;
    public TextMesh limitText;
    public TextMesh HpText;
    public TextMesh BoosterText;
    public Transform mainCamera;
    public float shakeSensitivity;
    public float Booster;
    bool Gameoverbool = false;
    public bool boosterOnOFF=false;

    public GameObject BoosterEffect;
    public bool isDamaged;
    bool movemove=false;
    int maxhp;

    float curTime;
    public float coolTime;








    // Start is called before the first frame update
    void Start()
    {
        Invoke("level2", 30f);
        Invoke("level3", 90f);
        level_two.SetActive(false);
        level_three.SetActive(false);
        gameovertext.SetActive(false);
        maxhp = hp;
        Textscore = GameObject.Find("ScoreText");
        HpBar = GameObject.Find("HpBar").GetComponent<Slider>();
        BoosterBar = GameObject.Find("BoosterBar").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        if (boosterOnOFF == true)
        {
            if (Player.transform.position.z <= 4)
            {
                Player.transform.Translate(0, 0, 0.1f);
            }
            //else
            //{
            //    Player.transform.position=new Vector3(Player.transform.position.x,Player.transform.position.y.tr)
            //}
            Booster = Booster - 0.5f;
            if (Booster < 0)
            {
                Booster = 0;
            }
            //BoosterObject.transform.localScale = new Vector3(Booster * 0.01f, 1, 1);
            BoosterBar.value = Booster;
            if (Booster <= 0)


            {
                level_Booster.SetActive(false);
                movemove = false;
                Time.timeScale = 1.0f;
                Invoke("GoBoosterReset", 1.5f);


            }
        }
        else

        {


            if (movemove == false && Player.transform.position.z > 0)
            {
                Player.transform.Translate(0, 0, -0.25f);
                if (Player.transform.position.z < 0)
                {
                    Player.transform.position = new Vector3(transform.position.x, 0, 0);
                }
            }




            if (LimitTime > 0 && Gameoverbool == false)
            {

                LimitTime = LimitTime - Time.deltaTime;
            }

            else
            {
                LimitTime = 0;
                print("GAME OVER");
                Gameover();
                //SceneManager.LoadScene(1);
            }



        }



        if (isDamaged == true && transform.position.z <= 0 && boosterOnOFF==false)
        {
            curTime += Time.deltaTime;
            CameraShake();
            if (curTime > coolTime)
            {
                isDamaged = false;
                curTime = 0;
                mainCamera.transform.position = new Vector3(0, mainCamera.transform.position.y, mainCamera.transform.position.z);
            }

        }



        limitText.text = "TIME : "+ LimitTime.ToString("F2");
        HpText.text = "HP : " + hp;
        HpBar.value = hp;
        //BoosterText.text = "BOOSTER : " + Booster;






    }
    
    public void PlusTime(float i)
    {
        LimitTime += i;
    }
    public void MinusHeart()
    {
        if (transform.position.z > 0 || boosterOnOFF == true)
        {
            return;
        }

        if (hp > 1)
        {
        hp--;
        }
        else
        {
            
            print("GAME OVER");
            //SceneManager.LoadScene(1);
            Gameover();
        }
    }


    void level2()
    {
        level_two.SetActive(true);
    }
    void level3()
    {
        level_three.SetActive(true);
    }

    public void Gameover()
    {
        
        Gameoverbool = true;
        hp = 0;
        //LimitTime = 0;
        limitText.text = "TIME : " + LimitTime.ToString("F2");
        HpText.text = "HP : " + hp;
        HpBar.value = hp;
        //GameObject.Find("Space").SetActive(true);
        Destroy(GameObject.Find("Player"));
        //GameObject.Find("Player").SetActive(false);
        
        gameovertext.SetActive(true);
       // space.SetActive(true);
    }

    public void PlusHeart()
    {
        

        if (hp < maxhp)
        {
            PlusBooster(1);
            hp++;
        }
        else
        {
            PlusBooster(5);
            PlusScore(2);
        }
    }
    public void PlusBooster(int i)
    {

        if (boosterOnOFF == true)
        {
            return;
            print("³ª¿À³ª?");
        }
           Booster = Booster + i;

       
        
        if (Booster >= 100)
        {
            Booster = 100;
            //BoosterObject.transform.localScale = new Vector3(1, 1, 1);
            BoosterBar.value = Booster;
            GoBooster();
        }
        else
        {
            //BoosterObject.transform.localScale = new Vector3(Booster * 0.01f, 1, 1);
            BoosterBar.value = Booster;
        }
    }
    void GoBooster()
    {
        movemove = true;
        level_Booster.SetActive(true);
        BoosterEffect.SetActive(true);
        boosterOnOFF = true;
        Time.timeScale = 2f;
        //Invoke("GoBoosterReset", 6f);

    }
    void GoBoosterReset()
    {
        Booster = 0;
        BoosterEffect.SetActive(false);
        boosterOnOFF = false;
        //Time.timeScale = 1f;
    }


    public void TextReset()
    {
        Textscore.GetComponent<TextMesh>().text = "Score : " + score;
    }

    
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Enemy" && CarRotate.check == true && boosterOnOFF == false)
        {
            PlusTime(1f);
            PlusBooster(6);
            //PlusScore(3);
            Destroy(Instantiate(effect, other.transform.position, other.transform.rotation), 1f);
            //scoreManager = GameObject.Find("ScoreText").GetComponent<Text>();
            TextReset();
            //Textscore.GetComponent<TextMesh>().text = ("Score : "+score);
            //print("check");
        }

    }
    public void PlusScore(int i)
    {
        score = score + i;
        TextReset();
    }

    public void CameraShake()
    {
        if (transform.position.z > 0 || boosterOnOFF == true)
        {
            return;
        }
        mainCamera.transform.position =
             new Vector3(Random.Range
             (-shakeSensitivity, shakeSensitivity),
             mainCamera.transform.position.y,
             mainCamera.transform.position.z);
    }
}
