using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScripted : MonoBehaviour
{
    public bool asteroidFinish = false;
    [SerializeField] private GameObject sphere;
    [SerializeField] private Sprite sphereBroke;
    private float speed = 2.3f;
    private Vector3 target = new Vector3(0, -12, 0);

    [SerializeField] private GameObject mainAudio;
    [SerializeField] private AudioClip asteroidMusic;

    void Awake()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        asteroidFinish = true;
        sphere.GetComponent<SpriteRenderer>().sprite = sphereBroke;
        mainAudio.GetComponent<AudioSource>().clip = asteroidMusic;
        mainAudio.GetComponent<AudioSource>().volume = 0.7f;
        mainAudio.GetComponent<AudioSource>().pitch = 0.9f;
        mainAudio.GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
    }
}
