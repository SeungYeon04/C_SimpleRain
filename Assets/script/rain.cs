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
        //�����ϰ� x�� y�� 00~00�߿��� ���Ͷ� 
        float x = Random.Range(50f, 550f);
        float y = Random.Range(900f, 1000f);
        transform.position = new Vector3(x, y, 0);
        //��ġ �� �־���

        //�� ������ ��
        type = Random.Range(1, 4);

        //�� ������ ũ�� ����
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
            size = 50.0f; //ȭ�� ����� Ű�������� ũ�� �̷��� �ҰԿ�̤�
            score = -5;
            GetComponent<SpriteRenderer>().color = new Color(255 / 255.0f, 100.0f / 255.0f, 100.0f / 255.0f, 255.0f / 255.0f);
        }
        else
        {
            size = 50.0f; //������ Ȯ�� �� ���̱�!
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
        //���� ��Ҵٴ� �� �ν� 
        if (coll.gameObject.tag == "ground") //���±׽����
        {
            Destroy(gameObject); //�� ������ ����������
        }

        if(coll.gameObject.tag == "rtan")//��ź���±�
        {
            Destroy(gameObject);
            GameManager.I.addScore(score);
        }    

    }
}
