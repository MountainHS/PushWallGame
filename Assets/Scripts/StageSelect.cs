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

    public void SelectStageA_1()
    {
        SceneManager.LoadScene("A-1");
    }
    public void SelectStageA_2()
    {
        SceneManager.LoadScene("A-2");
    }
    public void SelectStageA_3()
    {
        SceneManager.LoadScene("A-3");
    }
    public void SelectStageA_4()
    {
        SceneManager.LoadScene("A-4");
    }
    public void SelectStageA_5()
    {
        SceneManager.LoadScene("A-5");
    }
    public void SelectStageA_6()
    {
        SceneManager.LoadScene("A-6");
    }
    public void SelectStageA_7()
    {
        SceneManager.LoadScene("A-7");
    }
    public void SelectStageA_8()
    {
        SceneManager.LoadScene("A-8");
    }
    public void SelectStageA_9()
    {
        SceneManager.LoadScene("A-9");
    }
    public void SelectStageA_10()
    {
        SceneManager.LoadScene("A-10");
    }
    public void SelectStageB_1()
    {
        SceneManager.LoadScene("B-1");
    }
    public void SelectStageB_2()
    {
        SceneManager.LoadScene("B-2");
    }
    public void SelectStageB_3()
    {
        SceneManager.LoadScene("B-3");
    }
    public void SelectStageB_4()
    {
        SceneManager.LoadScene("B-4");
    }
    public void SelectStageB_5()
    {
        SceneManager.LoadScene("B-5");
    }
    public void SelectStageB_6()
    {
        SceneManager.LoadScene("B-6");
    }
    public void SelectStageB_7()
    {
        SceneManager.LoadScene("B-7");
    }
    public void SelectStageB_8()
    {
        SceneManager.LoadScene("B-8");
    }
    public void SelectStageB_9()
    {
        SceneManager.LoadScene("B-9");
    }
    public void SelectStageB_10()
    {
        SceneManager.LoadScene("B-10");
    }

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
