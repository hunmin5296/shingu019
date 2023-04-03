using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    public int[] array = new int[5];                           //array <-- 이름으로 5개의 배열(변수 int)을 선언
    public int[] points = { 83, 99, 52, 93, 15 };              //배열에 선언과 동시에 입력값 5개
    
    void Start()
    {
        array[0] = 2;
        array[1] = 10;                                  //각각  index(array[n]) 값에 숫자 값 입력
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);                        // i (0 -> 4) 까지 증가하면서 Console.log창에 각각의 값을 보여준다.
                                                        // array[0] , array[1], array[2] , array[3] , array[4] <--- for으로 해결
        }

        int sum = 0;                                    //중간 부분에도 변수가 필요할 경우 임의로 선언할수 있음

        for(int i = 0; i < points.Length; i++)          //points.Length 는 배열의 길이 값을 반환함
        {
            if(points[i] > 90)                          //90 초과 일때만 Debug.Log 조건식 출력
            {
                Debug.Log(points[i]);
            }
            sum += points[i];
        }
        int average = sum / points.Length;              //평균 값을 변수 선언하고 입력
        Debug.Log(average);                             //평균 값 출력
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
