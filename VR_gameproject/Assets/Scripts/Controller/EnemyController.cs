using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;          //�� �ӵ�
    private Rigidbody rb;               //������ �ٵ� ����
    private Transform Player;           //�÷��̾� ��ġ ����

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //�ڱ� �ڽ��� ������ �ٵ� �� �Է�
        Player = GameObject.FindGameObjectWithTag("Player").transform;          //�÷��̾��� ��ġ �� �Է�
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(Player.position , transform.position) > 5.0f)        //Vector3.Distance �Ÿ� ���� �Լ�
        {
            Vector3 direcrion = (Player.position - transform.position).normalized;      //�÷��̾�� ���� ��ġ ���͸� �����Ͽ� ���� ���ͷ� �̵�
            rb.MovePosition(transform.position + direcrion * speed * Time.deltaTime);   //�� �̵�
        }
    }
}
