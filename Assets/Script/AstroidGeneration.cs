using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidGeneration : MonoBehaviour
{

	public GameObject astroid;
	public GameObject indicator;

	public static int caseNum;

	private float distance = 35f;
	private float radarD = 2.69f;
	private Vector3 centerPlanet;
	private Vector3 centerRadar;
	private Vector3 radarInitial;

	private GameObject randomEnemy;
	private GameObject indicatorCopy;

	void Start()
	{
		centerPlanet = new Vector3(0, -12, 0);
		centerRadar = new Vector3(6.04f, -2.19f, 0);
		radarInitial = new Vector3(6.04f, -2.19f + radarD, 0);
		setRandomTime();
	}

	float enemyTimer = 0f;
	float enemySpawnTime = 0.5f;

	int angleRnd_large;
	int angleRnd_small;

	void FixedUpdate()
	{
		enemyTimer += Time.deltaTime;
		if (enemyTimer > enemySpawnTime)
		{
			astroid.SetActive(true);
			indicator.SetActive(true);

			angleRnd_large = Mathf.RoundToInt(Random.value * 12f);
			angleRnd_small = Mathf.RoundToInt((Random.value - 0.5f) * 2f);
			setRandomTime();

			astroid.transform.position = new Vector3(0, distance, 0);
			astroid.transform.RotateAround(centerPlanet, Vector3.forward, angleRnd_large * 30 + angleRnd_small * 8);
			indicator.transform.position = radarInitial;
			indicator.transform.RotateAround(centerRadar, Vector3.forward, angleRnd_large * 30 + angleRnd_small * 8);

			enemyTimer = 0f;
		}
//      if (CharaControl_ocean.reset == true)
//			enemyTimer = 0f;
		if(astroid.activeSelf == false)
			indicator.SetActive(false);
	}

	void setRandomTime()
	{
		enemySpawnTime = Random.Range(12f, 15f);
//		directionRnd = Random.Range(0, 4);
	}

}
