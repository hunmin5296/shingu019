using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;          //�� �ӵ�

    public float rotationSpeed = 1f;
    public GameObject bulletPrefab;
    public GameObject EnemyPivot;
    public Transform firePoint;
    public float fireRate = 1f;
    public float nextFireTime;

    private Rigidbody rb;               //������ �ٵ� ����
    private Transform Player;           //�÷��̾� ��ġ ����
    private Vector3 targetDirection;
    private Quaternion targetRotation;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //�ڱ� �ڽ��� ������ �ٵ� �� �Է�

        GameObject Temp = GameObject.FindGameObjectWithTag("Player");

        if(Temp != null)
        {
            Player = Temp.transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            if (Vector3.Distance(Player.position, transform.position) > 5.0f)        //Vector3.Distance �Ÿ� ���� �Լ�
            {
                Vector3 direction = (Player.position - transform.position).normalized;      //�÷��̾�� ���� ��ġ ���͸� �����Ͽ� ���� ���ͷ� �̵�
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);   //�� �̵�
            }
        }


        Vector3 targetDirection = (Player.position - transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        EnemyPivot.transform.rotation = Quaternion.Lerp(EnemyPivot.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);


        if(Time.time > nextFireTime)
        {
            nextFireTime = Time.time + 1f / fireRate;
            GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
            temp.GetComponent<ProjectileMove>().projectileType = ProjectileMove.PROJECTILETYPE.ENEMY;
        }
    }
}
