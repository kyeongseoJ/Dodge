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

        Destroy(gameObject, 3f);
    }
    // 트리거 충돌 시 자동으로 실행되는 메서드 
    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 상대방 게임 오브젝트가 Player 태그를 가졌나요?
        if (other.tag == "Player")
        {
            // 상대방(충돌한) 게임 오브젝트에서 PlayerController 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();

            // 상대방으로부터 PlayerController 컴포넌트를 가오는데 성공했다면..?
            if (playerController != null) // 비어있지않다면 {}안의 내용 실행
            {
                // playerController 컴포넌트의 Die() 매서드 실행
                playerController.Die();
            }
        }
    }
    
    void Update()
    {
        
    }
        
}
