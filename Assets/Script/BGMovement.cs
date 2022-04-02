using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour
{
	public GameObject planet;

	private GameObject bg;
	private float center;
	[SerializeField] private float centerX = 0f;
	private float rotateSpeed = 10f;
	void Start()
	{
		center = planet.GetComponent<Transform>().position.y;
		bg = gameObject;
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			rotateSpeed = 50f;
		}
		else
			rotateSpeed = 10f;
		if (Input.GetKey(KeyCode.A)) 
		{
			gameObject.transform.RotateAround(new Vector3(centerX, center, 0), Vector3.forward, -rotateSpeed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.D)) 
		{
			gameObject.transform.RotateAround(new Vector3(centerX, center, 0), Vector3.forward, rotateSpeed * Time.deltaTime);
		}

	}
}
