using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressionBar : MonoBehaviour
{
    private const int limit = 5000; // 10000 - 30000
    [SerializeField] private Slider progress;
    [SerializeField] private Canvas launch;

    private float prog = 0f;
    private int count = 0;
    void Start()
    {
        count = 0;
        prog = 0f;
    }
    void FixedUpdate()
    {
        ++count;
        if (count < limit)
        {
            prog = count / (1.0f * limit);
            progress.value = prog;
        }
        else 
        {
            prog = 1f;
            progress.value = prog;
            launch.gameObject.SetActive(true);

        }
    }
    private void Update()
    {
        if (prog == 1f && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
        }
    }
}
