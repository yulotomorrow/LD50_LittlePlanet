using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashTower : MonoBehaviour
{
    [SerializeField] private AudioClip crash;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Astroid") 
        {
            gameObject.GetComponent<AudioSource>().clip = crash;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
