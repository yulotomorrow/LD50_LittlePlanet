using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballShoot : MonoBehaviour
{
	private const float cannonballSpeed = 20f;
	private float pos;
	private float posX;
	private Vector3 originalPos;
	void Start()
	{
		pos = gameObject.transform.position.y;
		posX = gameObject.transform.position.x;
		originalPos = gameObject.transform.position;
	}

	private bool isShoot = false;
	void Update()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			isShoot = true;
		}
		if (isShoot) 
		{
			pos += Time.deltaTime * cannonballSpeed;
			gameObject.transform.position = new Vector3(posX, pos, 0);
		}
	}
}
