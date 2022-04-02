using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidBehavior : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 target = new Vector3(0, -12, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cannonball")
            gameObject.SetActive(false);
        else 
        {
            // do damage to planet and also set inactive

            gameObject.SetActive(false);
        }
    }
}
