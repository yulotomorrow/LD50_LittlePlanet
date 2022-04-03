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
	private Animator ayaAnim;
	private Vector3 ayaScale;
	void Start()
	{
		center = planet.GetComponent<Transform>().position.y;
		bg = gameObject;
		gameObject.transform.RotateAround(new Vector3(centerX, center, 0), Vector3.forward, initialAngle);
		angle = initialAngle;
		ayaAnim = aya.GetComponent<Animator>();
		ayaAnim.SetBool("isRun", false);
		ayaAnim.SetBool("isWalk", false);
		ayaScale = aya.transform.localScale;
}

	void Update()
	{
		if (dialogC.GetComponent<DialogueControl>().canControl)
		{
			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				rotateSpeed = 30f;
				ayaAnim.SetBool("isRun", true);
			}
			else
				rotateSpeed = 15f;
			if (Input.GetKey(KeyCode.A))
			{
				gameObject.transform.RotateAround(new Vector3(centerX, center, 0), Vector3.forward, -rotateSpeed * Time.deltaTime);
				angle += -rotateSpeed * Time.deltaTime;
				angle %= 360;
				ayaAnim.SetBool("isWalk", true);
				aya.transform.localScale = new Vector3(-ayaScale.x, ayaScale.y, ayaScale.z);			
			}
			else if (Input.GetKey(KeyCode.D))
			{
				gameObject.transform.RotateAround(new Vector3(centerX, center, 0), Vector3.forward, rotateSpeed * Time.deltaTime);
				angle += rotateSpeed * Time.deltaTime;
				angle %= 360;
				ayaAnim.SetBool("isWalk", true);
				aya.transform.localScale = ayaScale;
			}
			else 
			{
				ayaAnim.SetBool("isWalk", false);
			}
		}
	}
}
