using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenController : MonoBehaviour
{
    public GameObject MonsterTemp;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))    //마우스 버튼 오른쪽을 눌렀을때  ]
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);       //2D 모니터 카메라에서 3D 공간 좌표를 향해서 Ray를 검출

            RaycastHit hit;                                  //Hit 물리레이 변수 선언

            if(Physics.Raycast(cast, out hit))              //out 인수로 hit에 Ray값 검출된 값을 넣어준다.
            {
                if(hit.collider.tag == "Ground")                //hit 한곳의 Tag 가 Ground일때
                {
                    GameObject temp = (GameObject)Instantiate(MonsterTemp);         //몬스터 생성
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);    //몬스터 레이 위치 좌표에 생성
                }

                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);        //디버그 빨강 라인을 2초 동안 그려준다.

                Debug.Log("HIT => " + hit.collider.name);           //hit 된 물체의 namedmf 보여줌
            }
        }

    }
}
