using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtan : MonoBehaviour
{

    float direction = 0.5f;
    float toward = 100.0f; //�����ϴٰ� ���� ĳ�� ũ�� �����̴���..

    void Start()
    {

    }

   
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            toward *= -1;
            direction *= -1;
        }

        if (transform.position.x > 505f)
        {
            direction = -0.5f;
            toward = -100.0f;
        }

        if (transform.position.x < 38f)
        {
            direction = 0.5f;
            toward = 100.0f;
        }

        // FixedUpdate ���� FixedUpdate�� �̵�!
        transform.position += new Vector3(direction, 0, 0);
        //�¿���� 
        transform.localScale = new Vector3(toward, 100, 100);
    }
}
