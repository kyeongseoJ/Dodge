using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 이동에 사용할 리지드바디 컴포넌트
    public Rigidbody bulletRigidbody;
    // 탄알 이동 속력
    public float speed = 8f;

    void Start()
    {
        // 게임오브젝트에서 Rigidbody 컴포넌트를 찾아 bulletRigidbody에 할당
        bulletRigidbody = GetComponent<Rigidbody>();

        // Rigidbody의 속도 = 앞쪽방향 * 이동 속력
        bulletRigidbody.velocity = transform.forward * speed;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
