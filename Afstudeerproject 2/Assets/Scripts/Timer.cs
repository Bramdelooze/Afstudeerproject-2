using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public float timer;
    private float timerTime;

    // Start is called before the first frame update
    void Awake()
    {
        timerTime = timer;
    }

    // Update is called once per frame
    void Update()
    {
        RunTimer();
        timerText.text = timerTime.ToString("N0");
    }

    void RunTimer()
    {
        if(timerTime >= 0)
        {
            timerTime -= Time.deltaTime;
        }
    }
}
