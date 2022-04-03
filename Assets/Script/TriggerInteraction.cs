using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{
    private bool trig = false;
    [SerializeField] private Canvas canv;
    // Update is called once per frame
    void Update()
    {
        if (trig && Input.GetKeyDown(KeyCode.R))
        {
            gameObject.SetActive(false);
            canv.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            trig = true;
            canv.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            trig = false;
            canv.gameObject.SetActive(false);
        }
    }
}
