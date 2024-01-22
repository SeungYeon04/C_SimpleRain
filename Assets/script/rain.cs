using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    int type;
    float size;
    int score;

    void Start()
    {
        //랜덤하게 x는 y는 00~00중에서 나와라 
        float x = Random.Range(50f, 550f);
        float y = Random.Range(900f, 1000f);
        transform.position = new Vector3(x, y, 0);
        //위치 값 넣어줌

        //물 사이즈 값
        type = Random.Range(1, 4);

        //물 사이즈 크기 설정
        if(type == 1)
        {
            size = 50.5f;
            score = 1;
            GetComponent<SpriteRenderer>().color = new Color(100 / 255f, 100 / 255f, 255 / 255f, 255 / 255f);
        }
        else if(type == 2)
        {
            size = 100.0f;
            score = 3;
            GetComponent<SpriteRenderer>().color = new Color(130 / 255f, 130 / 255f, 255 / 255f, 255 / 255f);
        }
        else if(type == 3) 
        {
            size = 50.0f; //화면 사이즈를 키워버려서 크기 이렇게 할게요ㅜㅜ
            score = -5;
            GetComponent<SpriteRenderer>().color = new Color(255 / 255.0f, 100.0f / 255.0f, 100.0f / 255.0f, 255.0f / 255.0f);
        }
        else
        {
            size = 50.0f; //빨간색 확률 더 높이기!
            score = -5;
            GetComponent<SpriteRenderer>().color = new Color(255 / 255.0f, 100.0f / 255.0f, 100.0f / 255.0f, 255.0f / 255.0f);
        }

        transform.localScale = new Vector3(size, size, 0);
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //땅에 닿았다는 걸 인식 
        if (coll.gameObject.tag == "ground") //땅태그써먹음
        {
            Destroy(gameObject); //땅 닿으면 오브젝삭제
        }

        if(coll.gameObject.tag == "rtan")//르탄이태그
        {
            Destroy(gameObject);
            GameManager.I.addScore(score);
        }    

    }
}
