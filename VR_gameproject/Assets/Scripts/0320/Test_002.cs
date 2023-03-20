using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;                     //변수 int answer 선언
        answer = 1 + 2;                 //answer에 1 + 2 값 입력
        Debug.Log(answer);              //Console.log() answer 값을 보여줌

        int n1 = 8;                     //변수 int 선언 이름은 n1이고 8의 값을 입력
        int n2 = 9;                     //변수 int 선언 이름은 n1이고 9의 값을 입력
        int answer2;                    //변수 int answer2 선언 (기존에 answer 선언 되어있어서 다시 선언)
        answer2 = n1 + n2;              //answer2에 변수 n1 값과 n2 값의 더한 값을 입력
        Debug.Log(answer2);             //Console.log() answer2 값을 보여줌

        answer2 += 5;                   //answer2 = answer2 + 5의 축약
        Debug.Log(answer2);             //Console.log() answer2 값을 보여줌

        answer2++;                      //answer2 = answer2 + 1의 축약 보통 반복문에서 1씩 더해서 처리할때 쓰임
        Debug.Log(answer2);             //Console.log() answer2 값을 보여줌
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
