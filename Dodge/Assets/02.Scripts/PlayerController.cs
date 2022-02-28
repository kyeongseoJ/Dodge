using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 이동에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;
    //이동 속력 : 기본값 8f로 초깃값 지정
    public float speed = 7f;
    // 플레이어 비-/활성화를 위한 변수 생성
    public GameObject my;

    // Start is called before the first frame update
    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    private void Update()
    {
        // 수평축(Horizontal)과 수직축(Vertical)의 입력값을 감지해서 저장 
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력값과 이동속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0f, zSpeed)생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // Rigidbody의 속도에 newVelocity 할당
        playerRigidbody.velocity = newVelocity;

        // 한줄 축약 버전
        // playerRigidbody.velocity = new Vector3(xInput * speed, 0f, zInput * speed);

    }

    // 무중력 움직임
    void DirectInput()
    {
     
        //위쪽 방향키 left-, right-, DownArrow
        if (Input.GetKey(KeyCode.UpArrow) == true)        //만약 위방향 키를 눌렀다면
        {
            playerRigidbody.AddForce(0f, 0f, speed);      // X, Y, Z방향으로 힘을 xf만큼 가한다. 여기선 Z 양수방향: 즉 앞으로 8f의 힘으로 이동.
        }
        if(Input.GetKey(KeyCode.DownArrow) == true)  //아래방향키
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if(Input.GetKey(KeyCode.LeftArrow) == true)  // 좌측방향키
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);     // 좌우이동 X축 
        }
        if(Input.GetKey(KeyCode.RightArrow) == true) //우측방향키
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }  // else if 인경우 대각선은 안된다. if로만 이을 경우 방향키 2개 누르면 대각이동 가능하다.
    
    }

    public void Die() // 플레이어 비활성화
    {
        my.SetActive(false); // GameObject my : G 대문자 = 클래스
        // 편법? 좀더 간소화된 방법!
        // gameObject.SetActive(false); // gameObject : g 소문자 = 변수 유니티(=컴파일러)가 자동으로 지정해준다. 값 할당도 유니티가 알아서!
    }

}  
