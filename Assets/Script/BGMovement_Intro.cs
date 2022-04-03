using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement_Intro : MonoBehaviour
{
	public GameObject planet;

	private GameObject bg;
	private float center;
	[SerializeField] private float centerX = 0f;
	private float rotateSpeed = 10f;
	private const float initialAngle = 210;
	public float angle;
	[SerializeField] private GameObject aya;
	[SerializeField] private GameObject dialogC;
	void Start()
	{
		center = planet.GetComponent<Transform>().position.y;
		bg = gameObject;
		gameObject.transform.RotateAround(new Vector3(centerX, center, 0), Vector3.forward, initialAngle);
		angle = initialAngle;
	}

	void Update()
	{
		if (dialogC.GetComponent<DialogueControl>().canControl)
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
				angle += -rotateSpeed * Time.deltaTime;
				angle %= 360;
			}
			else if (Input.GetKey(KeyCode.D))
			{
				gameObject.transform.RotateAround(new Vector3(centerX, center, 0), Vector3.forward, rotateSpeed * Time.deltaTime);
				angle += rotateSpeed * Time.deltaTime;
				angle %= 360;
			}
		}
	}
}
