using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float rotationSpeed = 60f;
    void Update()
    {
        // Rotate �޼��� : �Է°�(�Ű�����)��  X, Y, Z �࿡ ����  ȸ������ �ް� ���� ȸ�����¿��� �Էµ� ����ŭ ��������� �� ȸ���Ѵ�.
        transform.Rotate(0f, rotationSpeed*Time.deltaTime, 0f);
    }
}
