using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public GameObject buttonStageA;
    public GameObject buttonStageB;
    public GameObject speedRun;
    public bool enableSpeedrun = false;
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

    void Update()
    {
        if (stageAOn)
        {
            if (Input.GetKey(KeyCode.N) == true)
                SceneManager.LoadScene("SelectSubStageA");

            if (Input.GetKey(KeyCode.Y) == true)
                SceneManager.LoadScene("A-1");
        }

        if (stageBOn)
        {
            if (Input.GetKey(KeyCode.N) == true)
                SceneManager.LoadScene("SelectSubStageB");

            if (Input.GetKey(KeyCode.Y) == true)
                SceneManager.LoadScene("B-1");
        }
    }
}
