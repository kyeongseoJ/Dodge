using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody bulletRigidbody;
    // ź�� �̵� �ӷ�
    public float speed = 8f;

    void Start()
    {
        // ���ӿ�����Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();

        // Rigidbody�� �ӵ� = ���ʹ��� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
