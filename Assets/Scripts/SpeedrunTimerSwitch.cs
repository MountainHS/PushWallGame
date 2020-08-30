// 말그대로 스피드런 타이머 킬지 말지 정하는 스위치임
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedrunTimerSwitch : MonoBehaviour
{
    public GameObject speedrunTimer;

    void Start()
    {
        if (PlayerPrefs.GetInt("enableSpeedrun") == 1)
            speedrunTimer.SetActive(true);
    }
}
