using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject rain;
    public GameObject Panel; //게임 오브젝트를 쥐여줌
    public Text scoreText; //점수TEXT
    int totalScore; //점수올리기 
    public static GameManager I; //싱글톤화(매니저는하나다)
    float limit = 5f; //시간초함수 
    public Text timeText; //시간초TEXT

    void Awake()
    {
        I = this;
    }

    void Start()
    {
        InvokeRepeating("makeRain", 0, 0.5f);
        initGame();
    }

    void Update()
    {
        limit -= Time.deltaTime;
        if(limit < 0) 
        {
            Time.timeScale = 0.0f;
            Panel.SetActive(true); //죽으면 판넬 뜨기
            limit = 0.0f;
        }
        timeText.text = limit.ToString("N2");
        //N2는 소숫점 둘째자리까지 잘라서 문자열로 만듦
    }

    void makeRain()
    {
        Instantiate(rain);
    }

    public void addScore(int score)
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();
    }

    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }

    void initGame()
    {
        Time.timeScale = 1.0f; //시간초기화 
        totalScore = 0; //원래점수초기화
        limit = 10.0f; //타임스퀘어초기화?  
    }
}
