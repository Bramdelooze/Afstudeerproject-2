using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProductivity : MonoBehaviour
{
    private Productivitybar productivitybarScript;
    public float normalFillSpeed = .1f;
    public float overWorkedTimer = 10;
    public float relaxTimer = 5;

    private float slowFillSpeed;
    private float boostFill;

    private float relaxTimerTime;
    private float timerTime;

    private bool isProductive = true;
    private bool isWorking;
    private bool hasBoost;


    private void Awake()
    {
        ResetOverworkedTimer();
        ResetRelaxTimer();
        boostFill = normalFillSpeed * 5;
        slowFillSpeed = normalFillSpeed / 4;
        productivitybarScript = GetComponent<Productivitybar>();
    }

    private void Update()
    {
        if(timerTime >= 0)
        {
            if (isWorking && isProductive)
            {
                timerTime -= Time.deltaTime;
            }
        }
        else if(relaxTimerTime >= 0)
        {
            isProductive = false;
            if (!isWorking)
            {
                relaxTimerTime -= Time.deltaTime;
            }
        }
        else
        {
            isProductive = true;
            ResetRelaxTimer();
            ResetOverworkedTimer();
            hasBoost = true;
        }
    }

    private void ResetOverworkedTimer()
    {
        timerTime = overWorkedTimer;
    }
    private void ResetRelaxTimer()
    {
        relaxTimerTime = relaxTimer;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Work Space")
        {
            if (hasBoost)
            {
                productivitybarScript.productivitySlider.value += boostFill;
                hasBoost = false;
            }
            isWorking = true;
            if (isProductive)
            {
                productivitybarScript.productivitySlider.value += normalFillSpeed * Time.deltaTime;
            }
            else
            {
                productivitybarScript.productivitySlider.value += slowFillSpeed * Time.deltaTime;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Work Space")
        {
            isWorking = false;
        }
    }
}
