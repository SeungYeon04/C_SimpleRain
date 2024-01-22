using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtan : MonoBehaviour
{

    float direction = 0.5f;
    float toward = 100.0f; //따라하다가 보니 캐릭 크기 기준이더라..

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

        // FixedUpdate 사용시 FixedUpdate로 이동!
        transform.position += new Vector3(direction, 0, 0);
        //좌우반전 
        transform.localScale = new Vector3(toward, 100, 100);
    }
}
