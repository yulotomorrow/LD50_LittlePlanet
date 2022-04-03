using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressionBar : MonoBehaviour
{
    private const int limit = 8000;
    [SerializeField] private Slider progress;
    [SerializeField] private Canvas launch;
    [SerializeField] private Text percent;

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
            percent.text = Mathf.Round(prog * 100) + "%";
        }
        else 
        {
            prog = 1f;
            progress.value = prog;
            launch.gameObject.SetActive(true);
            percent.text = "100%";
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
