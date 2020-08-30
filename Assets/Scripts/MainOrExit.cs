using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainOrExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) == true)
            SceneManager.LoadScene("6-1");
        
        if (Input.GetKeyDown("escape"))
        {
            #if UNITY_EDITOR
                            UnityEditor.EditorApplication.isPlaying = false;
            #elif UNITY_WEBPLAYER
                            Application.OpenURL("http://google.com");
            #else
                        Application.Quit();
            #endif
        }
    }
}
