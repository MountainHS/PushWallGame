using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public GameObject buttonStageA;
    public GameObject buttonStageB;
    public GameObject speedRun;
    bool stageAOn = false, stageBOn = false;

    public void SelectStageA()
    {
        buttonStageA.SetActive(false);
        buttonStageB.SetActive(false);
        speedRun.SetActive(true);
        stageAOn = true;
    }
    public void SelectStageB()
    {
        buttonStageA.SetActive(false);
        buttonStageB.SetActive(false);
        speedRun.SetActive(true);
        stageBOn = true;
    }

    void Start()
    {
        // currentStage: 현재스테이지를 나타내는 정수로 StageSelect 스크립트에서 시작할때 1로 설정 -> Timer 스크립트에서 스테이지 클리어 인식시 1씩 증가함
        PlayerPrefs.SetInt("currentStage", 1);
        PlayerPrefs.SetInt("enableSpeedrun", 0);
    }

    void Update()
    {
        if (stageAOn)
        {
            if (Input.GetKey(KeyCode.N) == true)
                SceneManager.LoadScene("SelectSubStageA");

            if (Input.GetKey(KeyCode.Y) == true)
            {
                PlayerPrefs.SetInt("enableSpeedrun", 1);
                PlayerPrefs.SetFloat("speedrunTime", 0f);
                SceneManager.LoadScene("A-1");
            }
        }

        if (stageBOn)
        {
            if (Input.GetKey(KeyCode.N) == true)
                SceneManager.LoadScene("SelectSubStageB");

            if (Input.GetKey(KeyCode.Y) == true)
            {
                PlayerPrefs.SetInt("enableSpeedrun", 1);
                PlayerPrefs.SetFloat("speedrunTime", 0f);
                SceneManager.LoadScene("B-1");
            }
        }
    }
}
