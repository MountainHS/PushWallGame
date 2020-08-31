using UnityEngine;

using System.Collections;
using JetBrains.Annotations;

public class move : MonoBehaviour
{
	public int a = 0;
	public int b = 0;
	public Vector3 target;
	// Use this for initialization
	void Start()
	{
	}
	// Update is called once per frame
	void Update()
	{
		moveObject();
	}


	void moveObject()
	{

		float keyHorizontal = Input.GetAxis("Horizontal");
		float keyVertical = Input.GetAxis("Vertical");
		Debug.Log(target);
		if (keyHorizontal > 0&&a == 0&&b==0)
		{
			a = 1;
			b = 1;
			target = new Vector3((int)(transform.position.x + 1.5f), 0.45f, (int)(transform.position.z+0.5f));
		}
		if (a == 1&&b==1)
        {
			Vector3 velo = Vector3.zero;
			transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.02f);
		}
		if (transform.position.x > (int)(transform.position.x + 1.5f) - 0.01&&b==1)
        {
			transform.position = target;
			a = 0;
			b = 0;
        }
		if (keyHorizontal < 0 && a == 0 && b==0)
		{
			a = 1;
			b = 2;
			target = new Vector3((int)(transform.position.x - 1.5f), 0.45f, (int)(transform.position.z+0.5f));
		}
		if (a == 1&&b==2)
		{
			Vector3 velo = Vector3.zero;
			transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.02f);
		}
		if (transform.position.x < (int)(transform.position.x - 1.5f) + 0.01&&b==2)
		{
			transform.position = target;
			a = 0;
			b = 0;
		}
		if (keyVertical > 0 && a == 0 && b == 0)
		{
			a = 1;
			b = 3;
			target = new Vector3((int)(transform.position.x+0.5f), 0.45f, (int)(transform.position.z + 1.5f));
		}
		if (a == 1 && b == 3)
		{
			Vector3 velo = Vector3.zero;
			transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.02f);
		}
		if (transform.position.z > (int)(transform.position.z + 1.5f) + 0.01 && b == 3)
		{
			transform.position = target;
			a = 0;
			b = 0;
		}
		if (keyVertical < 0 && a == 0 && b == 0)
		{
			a = 1;
			b = 4;
			target = new Vector3((int)(transform.position.x+0.5f), 0.45f, (int)(transform.position.z - 1.5f));
		}
		if (a == 1 && b == 4)
		{
			Vector3 velo = Vector3.zero;
			transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.02f);
		}
		if (transform.position.z < (int)(transform.position.z - 1.5f) + 0.01 && b == 4)
		{
			transform.position = target;
			a = 0;
			b = 0;
		}
	}
}