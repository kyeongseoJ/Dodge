using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // ������ ź���� ���� ������ 
    public GameObject bulletPrefab;

    // �ּ� ���� �ֱ�
    public float spawnRateMin = 0.5f;
    // �ִ� ���� �ֱ�
    public float spawnRateMax = 3f;
    
    // ���� ���� �ֱ� 
    private float spawnRate;
    // �ֱ� ���� �������� ���� �ð�
    private float timeAfterSpawn; 

    // �߻��� ��� : ��������
    private Transform target;

    void Start()
    {
        //�ֱ� ���� ���Ŀ� �����ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0;
        // ź�� ���� ������ spawnRateMin�� spawnRateMax���̿��� ���� �� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� �������� �ǹ�
        target = FindObjectOfType<PlayerController>().transform;
    }

    
    void Update()
    {
        // bullet ���� �ʴ� 60���� �����ǰ� �ִ�.
        Instantiate(bulletPrefab);

    }
}
