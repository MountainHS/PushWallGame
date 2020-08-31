using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public GameObject timerObject;
    public Timer timerScript;
    public void Start()
    {
        timerScript = timerObject.GetComponent<Timer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "goal")
        {
            if (PlayerPrefs.GetInt("enableSpeedrun") == 1 && PlayerPrefs.GetInt("currentStage") != 11))
            {
                timerScript.gameClear = true;
            }
            SceneManager.LoadScene("SampleScene");
        }
    }
}
