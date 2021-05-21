using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TravelDistanceTracker : MonoBehaviour
{
    private TMP_Text distanceText;
    [SerializeField] private float maxDistance = 1000;
    [SerializeField] private float normalTravelSpeed = 4;
    [SerializeField] private float slowTravelSpeed = 1;
    private float currentDistanceTraveled;
    private float currentTravelSpeed;

    private void OnEnable()
    {
        PlayerMovement.OnPlayerFlying += PlayerIsFlying;
        FocusBar.OnFocusNormal += MoveTravelSpeedToNormal;
        FocusBar.OnFocusTooLow += MoveTravelSpeedToSlow;
    }
    private void OnDisable()
    {
        PlayerMovement.OnPlayerFlying -= PlayerIsFlying;
        FocusBar.OnFocusNormal -= MoveTravelSpeedToNormal;
        FocusBar.OnFocusTooLow -= MoveTravelSpeedToSlow;
    }

    private void Awake()
    {
        distanceText = GetComponent<TMP_Text>();
        currentTravelSpeed = normalTravelSpeed;
    }

    void PlayerIsFlying()
    {
        MoveDistanceUp(currentTravelSpeed);
    }

    void MoveTravelSpeedToSlow()
    {
        currentTravelSpeed = slowTravelSpeed;
    }

    void MoveTravelSpeedToNormal()
    {
        currentTravelSpeed = normalTravelSpeed;
    }

    void MoveDistanceUp(float value)
    {
        currentDistanceTraveled += value * Time.deltaTime;
        ChangeDistanceText();
    }

    private void ChangeDistanceText()
    {
        distanceText.text = currentDistanceTraveled.ToString("N0") + "m / " + maxDistance + "m"; 
    }
}
