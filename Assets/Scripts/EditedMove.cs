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
	// 소수자릿수가 너무 커지면 문제가 생기는듯 유니티 상에서 소숫점 처리과정에서
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
			destPos.x = (float)(Math.Truncate(destPos.x * 1000) / 1000);	// 소수점 자르기
			destPos.y = (float)(Math.Truncate(destPos.y * 1000) / 1000);
			destPos.z = (float)(Math.Truncate(destPos.z * 1000) / 1000);
			Debug.Log(destPos);
			if (Math.Abs(destPos.x) <= maxHorizontal && Math.Abs(destPos.z) <= maxVertical)
			{
				moveRecog = false;
				moveActive = true;
				activeDelayTime = true;
			}
		}

		if (moveActive) 
		{
			if (currentPos == destPos)
			{
				moveActive = false;
				moveRecog = true;
			}

			Vector3 velo = Vector3.zero;
			transform.position = Vector3.SmoothDamp(currentPos, destPos, ref velo, 0.02f);
		}
	}
}