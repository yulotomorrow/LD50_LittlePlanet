using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CollisionEffect : MonoBehaviour
{
    private int count = 0;
    void Awake()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        count = 0;
    }
    
    private void FixedUpdate()
    {
        ++count;
        if(count > 4)
            gameObject.SetActive(false);
    }

}
