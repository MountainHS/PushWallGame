using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timeText;
    float time = 0f;
    public bool gameClear = false;

    // Update is called once per frame
    void Update()
    {
        if (!gameClear)
        {
            time += Time.deltaTime;
            string timeString = time.ToString("N2");
            timeText.text = "걸린 시간: " + timeString;
        }
        else
        {
            int currentStage = PlayerPrefs.GetInt("currentStage");
            PlayerPrefs.SetInt("currentStage", currentStage++);
            SceneManager.LoadScene("A-" + currentStage.ToString());
        }
    }
}
