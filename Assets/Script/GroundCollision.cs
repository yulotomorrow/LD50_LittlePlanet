using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private GameObject groundSpark;
    private int spriteIndex = 1;
    void Start()
    {
        spriteIndex = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Astroid") 
        {
            gameObject.GetComponent<AudioSource>().Play();
            groundSpark.SetActive(true);
            if (spriteIndex < sprites.Length) 
            {   
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[spriteIndex];
                ++spriteIndex;
            }
        }
    }
}
