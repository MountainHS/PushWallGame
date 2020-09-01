using UnityEngine;
using System.Collections;
using System;
using JetBrains.Annotations;
// 스테이지 매니저만 연결시키면 됨.
public class EditedMove : MonoBehaviour
{
	public GameObject stageManagerObject;
	StageManager stageManagerScript;
	Vector3 currentPos, destPos;
	float delayTime = 0.4f;
	float inputX, inputZ, maxHorizontal, maxVertical;
	bool moveActive = false, moveRecog = true, activeDelayTime = false;

	bool MoveActive(float x, float z)
	{
		if (Math.Abs(x) >= 0.2f ^ Math.Abs(z) >= 0.2f)
		{
			return true;
		}
		else
			return false;
	}

	void Start()
    {
		currentPos = transform.position;
		stageManagerScript = stageManagerObject.GetComponent<StageManager>();

		maxHorizontal = (int)stageManagerScript.HBN / 2;
		maxVertical = (int)stageManagerScript.VBN / 2;
	}
	// 반올림하는 함수 잇어야할듯 스크립트 상에서 연산할때랑 유니티 상에 표현할때 소수 처리방식이 다른게 문제인듯
    void Update()
	{
		currentPos = transform.position;
		float keyHorizontal = Input.GetAxis("Horizontal");
		float keyVertical = Input.GetAxis("Vertical");
		
		inputX = 0f;
		inputZ = 0f;

		if (activeDelayTime)
		{
			delayTime -= Time.deltaTime;
			if (delayTime <= 0)
			{
				delayTime = 0.4f;
				activeDelayTime = false;
			}
		}

		if (MoveActive(keyHorizontal, keyVertical) && moveRecog && delayTime == 0.4f)
		{
			if (keyHorizontal >= 0.2)
				inputX = 1f;
			if (keyVertical >= 0.2)
				inputZ = 1f;

			if (keyHorizontal <= -0.2)
				inputX = -1f;
			if (keyVertical <= -0.2)
				inputZ = -1f;

			Vector3 inputPos = new Vector3 (inputX, 0, inputZ);
			destPos = inputPos + currentPos;  // 움직일 목표 위치
			Debug.Log(destPos);
			if (Math.Abs(destPos.x) <= maxHorizontal && Math.Abs(destPos.z) <= maxVertical)
			{
				moveRecog = false;
				moveActive = true;
				activeDelayTime = true;
			}
			else
				destPos = new Vector3(0f, 0f, 0f);
		}

		if (moveActive)     // moveActive가 거짓이라면 움직일 위치 설정
		{
			Vector3 velo = Vector3.zero;
			transform.position = Vector3.SmoothDamp(currentPos, destPos, ref velo, 0.02f);

			if (currentPos == destPos)
			{
				moveActive = false;
				moveRecog = true;
			}
		}
	}
}