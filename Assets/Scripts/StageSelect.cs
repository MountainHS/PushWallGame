using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public void SelectStageA()
    {
        SceneManager.LoadScene("SelectSubStageA");
    }
    public void SelectStageB()
    {
        SceneManager.LoadScene("SelectSubStageB");
    }
}
