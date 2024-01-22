using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject rain;
    public GameObject Panel; //���� ������Ʈ�� �㿩��
    public Text scoreText; //����TEXT
    int totalScore; //�����ø��� 
    public static GameManager I; //�̱���ȭ(�Ŵ������ϳ���)
    float limit = 5f; //�ð����Լ� 
    public Text timeText; //�ð���TEXT

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
            Panel.SetActive(true); //������ �ǳ� �߱�
            limit = 0.0f;
        }
        timeText.text = limit.ToString("N2");
        //N2�� �Ҽ��� ��°�ڸ����� �߶� ���ڿ��� ����
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
        Time.timeScale = 1.0f; //�ð��ʱ�ȭ 
        totalScore = 0; //���������ʱ�ȭ
        limit = 10.0f; //Ÿ�ӽ������ʱ�ȭ?  
    }
}
