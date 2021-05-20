using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FocusBar : MonoBehaviour
{
    private Slider focusSlider;

    public static event Action OnFocusTooLow;
    public static event Action OnFocusNormal;
    [SerializeField] private float maxEffectiveFocus = 20;

    private void OnEnable()
    {
        PlayerMovement.OnPlayerFlying += PlayerIsFlying;
    }

    private void OnDisable()
    {
        PlayerMovement.OnPlayerFlying -= PlayerIsFlying;
    }

    private void Awake()
    {
        focusSlider = GetComponent<Slider>();
    }

    private void Update()
    {
        if(focusSlider.value < maxEffectiveFocus && OnFocusTooLow != null)
        {
            OnFocusTooLow();
        }
        else if(OnFocusNormal != null)
        {
            OnFocusNormal();
        }
    }

    private void PlayerIsFlying()
    {
        MoveSlider(-1 * Time.deltaTime);
    }

    public void MoveSlider(float value)
    {
        focusSlider.value += value;
    }
}