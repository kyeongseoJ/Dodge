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

    // �ӽ� �ð� ���� Ȯ�ο� ����
    // float sumTime = 0;

    void Start()
    {
        //�ֱ� ���� ���Ŀ� �����ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        // ź�� ���� ������ spawnRateMin�� spawnRateMax���̿��� ���� �� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� �������� �ǹ�
        target = FindObjectOfType<PlayerController>().transform;
    }

    
    void Update()
    {
        // timeAfterSpawn ���� : timeAfterSpawn�� �󸶳� �������� �����ð��� ����� 
        timeAfterSpawn += Time.deltaTime;

        // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ� ������ �ҰŴ�.
        if(timeAfterSpawn >= spawnRate)
        {
        // bullet ���� �ʴ� 60���� �����ǰ� �ִ�.
        // bullet Prefab�� �������� ��ġ�� ȸ�� ������ �ְ� ����
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        // ������ bullet ���� ������Ʈ�� �������(=Z��)�� target(=Player)�� ���ϵ��� ȸ��
        bullet.transform.LookAt(target);


        // ������ ���� ������ spawnRateMin, spawnRateMax ���׿��� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // ������ �ð��� ����
        timeAfterSpawn = 0f;

        }

        //float time = Time.deltaTime;
        //sumTime += time;
        //Debug.Log("�����Ӵ� �ð� : " + time);
        //Debug.Log("���� �÷��� �ð� : " + (int)sumTime);

        ////Debug.Log(Time.deltaTime); // �������Ӵ� ����ð� Ȯ�� ����
    }
}
