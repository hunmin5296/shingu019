using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)             //i가 0부터 5미만 까지 1씩증가
        {
            Debug.Log(i);
        }

        for (int i = 0; i < 10; i+= 2)          //i가 0부터 10미만까지 +2씩 증가
        {
            Debug.Log(i);
        }

        for (int i = 3; i > 0 ; i--)            //i가 3부터 0초과까지 1씩 감소
        {
            Debug.Log(i);
        }

        int sum = 0;
        for (int i = 1; i < 10; i++)            //i가 1부터 10미만까지 1씩 증가
        {
            sum += i;                           // (처리) 각 i의 값을 더한다.
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
