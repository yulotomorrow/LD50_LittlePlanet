using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressionBar : MonoBehaviour
{
    private const int limit = 30000;
    [SerializeField] private Slider progress;
    void Start()
    {
        
    }

    private float prog = 0f;
    private int count = 0;
    void FixedUpdate()
    {
        ++count;
        prog = count / (1.0f * limit);
        progress.value = prog;
    }
}
