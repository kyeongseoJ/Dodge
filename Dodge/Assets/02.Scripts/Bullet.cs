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

        Destroy(gameObject, 3f);
    }
    // Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼��� 
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ���� ���� ������Ʈ�� Player �±׸� ��������?
        if (other.tag == "Player")
        {
            // ����(�浹��) ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();

            // �������κ��� PlayerController ������Ʈ�� �����µ� �����ߴٸ�..?
            if (playerController != null) // ��������ʴٸ� {}���� ���� ����
            {
                // playerController ������Ʈ�� Die() �ż��� ����
                playerController.Die();
            }
        }
    }
    
    void Update()
    {
        
    }
        
}
