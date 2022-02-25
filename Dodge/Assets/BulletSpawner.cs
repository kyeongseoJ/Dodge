using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // 생성할 탄알의 원본 프리팹 
    public GameObject bulletPrefab;

    // 발사할 대상 : 변수선언
    private Transform target;
    
    void Start()
    {
        // PlayerController 컴포넌트를 가진 게임 오브젝트를 찾아서 그 오브젝트의 위치값을 가져오란 의미
        target = FindObjectOfType<PlayerController>().transform;
    }

    
    void Update()
    {
        
    }
}
