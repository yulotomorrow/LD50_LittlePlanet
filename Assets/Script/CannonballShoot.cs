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

	
	void Update()
	{
		pos += Time.deltaTime * cannonballSpeed;
		gameObject.transform.position = new Vector3(posX, pos, 0);
		if (Vector3.Distance(gameObject.transform.position, originalPos) > 15f)
			Destroy(gameObject);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Destroy(gameObject);
	}
}
