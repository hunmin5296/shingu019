using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ProjectileMove : MonoBehaviour
{
    public enum PROJECTILETYPE
    {
        PLAYER,
        ENEMY
    }
    public Vector3 launchDirection;
    public PROJECTILETYPE projectileType = PROJECTILETYPE.PLAYER;


    private void OnCollisionEnter(Collision collision)
    {   //벽에 충돌시 파괴
        if(collision.gameObject.name == "Wall")
        {
            Destroy(this.gameObject);
        }
  
    }

    private void OnTriggerEnter(Collider other)        //Trigger 함수
    {   //벽에 충돌시 파괴
        if (other.gameObject.tag == "Wall")             //Name-> Tag 로 변환
        {
            Destroy(this.gameObject);
        }
      
        //몬스터에 충돌시
        if (other.gameObject.tag == "Monster" && projectileType == PROJECTILETYPE.PLAYER)
        {
            other.gameObject.GetComponent<MonsterController>().Damaged(1);
            other.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Player" && projectileType == PROJECTILETYPE.ENEMY)
        {
            other.gameObject.GetComponent<PlayerController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        //시간대비 이동 량 float 값으로 선언
        float moveAmount = 3 * Time.fixedDeltaTime;
        //launchDirection 방향으로 발사체 이동 (Translate) 이동 시키는 함수
        transform.Translate(launchDirection * moveAmount);
    }
}
