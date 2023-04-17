using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int Monster_Hp = 5;              //몬스터 HP tjsdjs

    public void Damaged(int Damage)         //데미지 받는 함수 생성
    {
        Monster_Hp -= Damage;               //받은 데미지 HP에 반영

        if (Monster_Hp < 0)                 //0 이하로 떨어질시
        {
            Destroy(this.gameObject);       //몬스터 오브젝트 파괴
        }
    }
}
