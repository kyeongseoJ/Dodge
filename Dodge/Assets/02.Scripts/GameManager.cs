using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI 관련 라이브러리 사용할래
using UnityEngine.UI;
// Scene 관련 라이브러리 사용할래
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // 게임오버 시 활성호할 텍스트 게임 오브젝트
    public GameObject gameOverText;
    // 생존 시간을 표시할 텍스트 컴포넌트
    public Text timeText;
    // 최고 기록을 표시할 텍스트 컴포넌트
    public Text recordText;

    // 실제 생존 시간
    private float surviveTime;
    // 게임 오버 상태 : 죽었는지 살았는지
    private bool isGameover;

    private void Start()
    {
        // 생존시간과 게임오버 상태 초기화
        surviveTime = 0f;
        isGameover = false;
    }

    void Update()
    {
        // 게임오버가 아닌 동안
        if (!isGameover)
        {
            // 생존 시간 갱신
            surviveTime += Time.deltaTime;
            // 갱신한 생존시간을 timeText 컴포넌트를 이용해 표시
            timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {
            // 게임오버인 상태에서 'R'키 누른다면,
            if (Input.GetKeyDown(KeyCode.R))
            {
                // SampleScene 씬을 로드
                SceneManager.LoadScene("SampleScene");
                // SceneManager.LoadScene(0);
            }
        }
    }

    // 현재 게임을 게임오버 상태로 변경하는 메서드
    public void EndGame()
    {
        // 현재 상태를 게임오버 상태로 전환
        isGameover = true;
        // 게임오버 텍스트 GameObject를 활성화(true)/비활성화(false) 진행
        gameOverText.SetActive(true);

        // timeText.enabled = true; // 오브젝트 내의 컴포넌트 활성화/비활성화

        // 기록을 데이터로 저장하는 방법
        // 돈 1000원을 데이터로저장하고 싶다 PlayerPrefs.SetInt( “Money” , 1000);
        // 돈이란 항목을 가져와서 쓰고 싶다. PlayerPrefs.GetInt( “Money"");
        // 닉네임을 데이터로 저장하고 싶다. PlayerPrefs.SetString( “Nickname” , "KS");

        // 사용시간을 저장하고 이전기록과 비교해서 최고기록을 판단한다.
        // PlayerPrefs => (PlayerPreference)의 약칭

        // 'BestTime' 키로 저장된 이전까지의 최고 기록을 가져오기
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // 이전까지의 최고 기록과 현재 생존 시간비교
        if(bestTime < surviveTime)
        {
            // 최고 기록 값을 현재 생존 시간 값으로 변경
            bestTime = surviveTime;
            // 변경된 최고 기록을 "BestTime"키로 저장
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        // 최고 기록을 recordText 컴포넌트에 표시
        recordText.text = "Best Time : " + (int)bestTime;

    }
}
