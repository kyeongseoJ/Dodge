using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI ���� ���̺귯�� ����ҷ�
using UnityEngine.UI;
// Scene ���� ���̺귯�� ����ҷ�
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // ���ӿ��� �� Ȱ��ȣ�� �ؽ�Ʈ ���� ������Ʈ
    public GameObject gameOverText;
    // ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text timeText;
    // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recode;

    // ���� ���� �ð�
    private float surviveTime;
    // ���� ���� ���� : �׾����� ��Ҵ���
    private bool isGameover;

    private void Start()
    {
        // �����ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0f;
        isGameover = false;
    }

    void Update()
    {
        // ���ӿ����� �ƴ� ����
        if (!isGameover)
        {
            // ���� �ð� ����
            surviveTime += Time.deltaTime;
            // ������ �����ð��� timeText ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time : " + (int)surviveTime;
        }
    }

    // ���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {
        // ���� ���¸� ���ӿ��� ���·� ��ȯ
        isGameover = true;
    }
}
