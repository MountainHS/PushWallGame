using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    void Start()
    {
        // VBN: 세로 길이, HBN: 가로 길이 저장 변수
        float VBN = 7.0f, HBN = 7.0f;

        transform.localScale = new Vector3(HBN * 0.1f, 1, VBN * 0.1f);  // 세로, 가로 길이 만큼 맵 크기 변화
    }
}



