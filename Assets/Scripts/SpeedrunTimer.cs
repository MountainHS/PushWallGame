// 스피드런 타이머는 처음에 비활성화 되어있다가 스피드런 모드를 키면 그때 A-1에서 먼저 켜진 다음에 A-10 클리어할때까지 시간 잼
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeedrunTimer : MonoBehaviour
{
    public Text speedrunTime;
    float time;

    void Start()
    {
        time = PlayerPrefs.GetFloat("speedrunTime");
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("enableSpeedrun") == 1 && PlayerPrefs.GetInt("currentStage") != 11) // 스피드런 모드 켜져 있고 10스테이지 내이면 시간 계속 재기
        {
            time = PlayerPrefs.GetFloat("speedrunTime");                                            // PlayerPrefs로 씬 이동해도 시간 계속 저장됨
            float newTime = PlayerPrefs.GetFloat("speedrunTime") + Time.deltaTime;
            PlayerPrefs.SetFloat("speedrunTime", newTime);
            string timeString = time.ToString("N2");
            speedrunTime.text = "총 걸린 시간: " + timeString;
        }
    }
}
