using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Focusbar : MonoBehaviour
{
    private Slider focusSlider;

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

    private void PlayerIsFlying()
    {
        MoveSliderDown(1 * Time.deltaTime);
    }

    public void MoveSliderDown(float value)
    {
        focusSlider.value -= value;
    }
}