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
	[SerializeField] private GameObject aya;
	[SerializeField] private GameObject cannon;
	private Animator ayaAnim;
	private Animator cannonAnim;
	private Vector3 cannonScale;
	void Start()
	{
		center = planet.GetComponent<Transform>().position.y;
		bg = gameObject;
		ayaAnim = aya.GetComponent<Animator>();
		cannonAnim = cannon.GetComponent<Animator>();
		ayaAnim.SetBool("isRun", false);
		ayaAnim.SetBool("isWalk", false);
		cannonAnim.SetBool("isWalk", false);
		cannonScale = cannon.transform.localScale;
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			rotateSpeed = 30f;
			ayaAnim.SetBool("isRun", true);
			cannonAnim.speed = 1.0f;
		}
		else
		{
			rotateSpeed = 15f;
			cannonAnim.speed = 0.5f;
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			gameObject.transform.RotateAround(new Vector3(centerX, center, 0), Vector3.forward, -rotateSpeed * Time.deltaTime);
			ayaAnim.SetBool("isWalk", true);
			cannonAnim.SetBool("isWalk", true);
			cannon.transform.localScale = new Vector3(-cannonScale.x, cannonScale.y, cannonScale.z);
		}
		else if (Input.GetKey(KeyCode.D)) 
		{
			gameObject.transform.RotateAround(new Vector3(centerX, center, 0), Vector3.forward, rotateSpeed * Time.deltaTime);
			ayaAnim.SetBool("isWalk", true);
			cannon.transform.localScale = cannonScale;
			cannonAnim.SetBool("isWalk", true);
		}
		else
		{
			ayaAnim.SetBool("isWalk", false);
			cannonAnim.SetBool("isWalk", false);
		}
	}
}
