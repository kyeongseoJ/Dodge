using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    //�̵� �ӷ� : �⺻�� 8f�� �ʱ갪 ����
    public float speed = 7f;
    // �÷��̾� ��-/Ȱ��ȭ�� ���� ���� ����
    public GameObject my;

    // Start is called before the first frame update
    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    private void Update()
    {
        // ������(Horizontal)�� ������(Vertical)�� �Է°��� �����ؼ� ���� 
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵��ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 �ӵ��� (xSpeed, 0f, zSpeed)����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // Rigidbody�� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;

        // ���� ��� ����
        // playerRigidbody.velocity = new Vector3(xInput * speed, 0f, zInput * speed);

    }

    // ���߷� ������
    void DirectInput()
    {
     
        //���� ����Ű left-, right-, DownArrow
        if (Input.GetKey(KeyCode.UpArrow) == true)        //���� ������ Ű�� �����ٸ�
        {
            playerRigidbody.AddForce(0f, 0f, speed);      // X, Y, Z�������� ���� xf��ŭ ���Ѵ�. ���⼱ Z �������: �� ������ 8f�� ������ �̵�.
        }
        if(Input.GetKey(KeyCode.DownArrow) == true)  //�Ʒ�����Ű
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if(Input.GetKey(KeyCode.LeftArrow) == true)  // ��������Ű
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);     // �¿��̵� X�� 
        }
        if(Input.GetKey(KeyCode.RightArrow) == true) //��������Ű
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }  // else if �ΰ�� �밢���� �ȵȴ�. if�θ� ���� ��� ����Ű 2�� ������ �밢�̵� �����ϴ�.
    
    }

    public void Die() // �÷��̾� ��Ȱ��ȭ
    {
        my.SetActive(false); // GameObject my : G �빮�� = Ŭ����
        // ���? ���� ����ȭ�� ���!
        // gameObject.SetActive(false); // gameObject : g �ҹ��� = ���� ����Ƽ(=�����Ϸ�)�� �ڵ����� �������ش�. �� �Ҵ絵 ����Ƽ�� �˾Ƽ�!
    }

}  
