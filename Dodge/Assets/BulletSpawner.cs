using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // ������ ź���� ���� ������ 
    public GameObject bulletPrefab;

    // �߻��� ��� : ��������
    private Transform target;
    
    void Start()
    {
        // PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� �������� �ǹ�
        target = FindObjectOfType<PlayerController>().transform;
    }

    
    void Update()
    {
        
    }
}
