using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour
{
    public GameObject planet;

    private GameObject bg;
    private float center;
    private const float centerX = 0f;
    private const float rotateSpeed = 10f;
    void Start()
    {
        center = planet.GetComponent<Transform>().position.y;
        bg = gameObject;
    }

    void Update()
    {
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
