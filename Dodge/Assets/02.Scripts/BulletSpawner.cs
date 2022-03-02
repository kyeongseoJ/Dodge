using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // 생성할 탄알의 원본 프리팹 
    public GameObject bulletPrefab;

    // 최소 생성 주기
    public float spawnRateMin = 0.5f;
    // 최대 생성 주기
    public float spawnRateMax = 3f;
    
    // 실제 생성 주기 
    private float spawnRate;
    // 최근 생성 시점에서 지난 시간
    private float timeAfterSpawn; 

    // 발사할 대상 : 변수선언
    private Transform target;

    // 임시 시간 누적 확인용 변수
    // float sumTime = 0;

    void Start()
    {
        //최근 생성 이후에 누적시간을 0으로 초기화
        timeAfterSpawn = 0f;
        // 탄알 생성 간격을 spawnRateMin과 spawnRateMax사이에서 랜덤 값 지정
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // PlayerController 컴포넌트를 가진 게임 오브젝트를 찾아서 그 오브젝트의 위치값을 가져오란 의미
        target = FindObjectOfType<PlayerController>().transform;
    }

    
    void Update()
    {
        // timeAfterSpawn 갱신 : timeAfterSpawn에 얼마나 지났는지 누적시간을 담아줌 
        timeAfterSpawn += Time.deltaTime;

        // 최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 같다면 시작을 할거다.
        if(timeAfterSpawn >= spawnRate)
        {
        // bullet 생성 초당 60개씩 생성되고 있다.
        // bullet Prefab의 복제본을 위치와 회전 설정을 주고 생성
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        // 생성된 bullet 게임 오브젝트에 정면방향(=Z값)이 target(=Player)를 향하도록 회전
        bullet.transform.LookAt(target);


        // 다음번 생성 간격을 spawnRateMin, spawnRateMax 사잉에서 지정
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // 누적된 시간을 리셋
        timeAfterSpawn = 0f;

        }

        //float time = Time.deltaTime;
        //sumTime += time;
        //Debug.Log("프레임당 시간 : " + time);
        //Debug.Log("현재 플레이 시간 : " + (int)sumTime);

        ////Debug.Log(Time.deltaTime); // 한프레임당 재생시간 확인 가능
    }
}
