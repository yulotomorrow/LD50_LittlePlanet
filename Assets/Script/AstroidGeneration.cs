using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidGeneration : MonoBehaviour
{

	public GameObject[] astroid;
	public GameObject[] indicator;

	public static int caseNum;

	private float distance = 10f;
	private float radarD = 2.69f;
	private Vector3 centerPlanet;
	private Vector3 centerRadar;
	private Vector3 radarInitial;

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
	int astroidindex = 0;
	bool canGenerate = false;
	void FixedUpdate()
	{
		enemyTimer += Time.deltaTime;
		canGenerate = false;
		if (enemyTimer > enemySpawnTime)
		{
			for(int i = 0; i <= 2; ++i) 
			{
				if (astroid[i].activeSelf == false)
				{
					astroidindex = i;
					canGenerate = true;
					break;
				}
			}
			if (canGenerate)
			{
				astroid[astroidindex].SetActive(true);
				indicator[astroidindex].SetActive(true);

				angleRnd_large = Mathf.RoundToInt(Random.value * 12f);
				angleRnd_small = Mathf.RoundToInt((Random.value - 0.5f) * 2f);
				setRandomTime();

				astroid[astroidindex].transform.position = new Vector3(0, distance, 0);
				astroid[astroidindex].transform.RotateAround(centerPlanet, Vector3.forward, angleRnd_large * 30 + angleRnd_small * 8);
				indicator[astroidindex].transform.position = radarInitial;
				indicator[astroidindex].transform.RotateAround(centerRadar, Vector3.forward, angleRnd_large * 30 + angleRnd_small * 8);

				enemyTimer = 0f;
			}
		}

		for (int j = 0; j <= 2; ++j)
		{
			if (astroid[j].activeSelf == false)
				indicator[j].SetActive(false);
		}
	}

	void setRandomTime()
	{
		enemySpawnTime = Random.Range(5f, 8f);
//		directionRnd = Random.Range(0, 4);
	}

}
