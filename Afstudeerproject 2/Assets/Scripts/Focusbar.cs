using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FocusBar : MonoBehaviour
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
        MoveSlider(-1 * Time.deltaTime);
    }

    public void MoveSlider(float value)
    {
        focusSlider.value += value;
    }
}