using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpark : MonoBehaviour
{
    private int count = 0;
    void OnEnable()
    {
        count = 0;
    }

    private void FixedUpdate()
    {
        ++count;
        if (count > 4)
            gameObject.SetActive(false);
    }

}
