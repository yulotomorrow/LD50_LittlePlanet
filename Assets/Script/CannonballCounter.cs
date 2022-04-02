using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballCounter : MonoBehaviour
{
	public int woodenBallCount = 10;
	public int ironBallCount = 0;
	public int woodCount = 0;
	public int ironCount = 0;
	[SerializeField] private GameObject cannonBall;
	private Vector3 pos;
	void Start()
	{
		pos = cannonBall.transform.position;   
	}
	private bool isShoot = false;

	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Space) && woodenBallCount > 0)
		{
			isShoot = true;
		}
		else
			isShoot = false;
		if (isShoot)
		{
			GameObject gameObject = Instantiate(cannonBall);
			gameObject.transform.position = pos;
			gameObject.SetActive(true);
		}
	}
}
