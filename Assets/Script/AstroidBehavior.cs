using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AstroidBehavior : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 target = new Vector3(0, -12, 0);

    private float health = 100.0f;
    private float rotationSpeed;
    void Start()
    {
        rotationSpeed = Random.value - 0.5f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target, speed * Time.deltaTime);
        gameObject.transform.Rotate(rotationSpeed * 200 * Time.deltaTime * Vector3.forward, Space.Self);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cannonball")
            gameObject.SetActive(false);
        else if (collision.tag == "Player")
        {
            //gameObject.SetActive(false);
            SceneManager.LoadScene("FailScene", LoadSceneMode.Single);
        }
        else 
        {
            // do damage to planet and also set inactive

            gameObject.SetActive(false);
        }
    }
}
