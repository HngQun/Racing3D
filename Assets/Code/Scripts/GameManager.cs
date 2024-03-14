using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeOver = 30f;
    public bool endGame = false;
    public bool wingame = false;

    private static GameManager instance;

    public GameObject gameoverOb;
    public GameObject timegameOb;
    public GameObject gamewinOb;

    [SerializeField]
    private float timePlus = 30f;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject gameManagerGameObject = new GameObject("GameManager");
                    instance = gameManagerGameObject.AddComponent<GameManager>();
                }
            }

            return instance;
        }
    }

    private void Update()
    {
        if (!endGame)
        {
            timeOver -= Time.deltaTime;
            if(timeOver<=0){
                timegameOb.SetActive(false);
                gameoverOb.SetActive(true);
                GameOver();
            }
        }
        if(wingame){
            timegameOb.SetActive(false);
            gamewinOb.SetActive(true);
        }
    }

    public void GameOver(){
        endGame = true;
    }

    public void CheckPoint(){
        if(!endGame){
            timeOver += timePlus;
        }
    }
    public void WinPoint(){
        if(!endGame){
            wingame = true;
        }
    }
}
