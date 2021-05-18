using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Focusbar : MonoBehaviour
{
    private Slider focusSlider;

    private void Awake()
    {
        focusSlider = GetComponent<Slider>();
    }

    public void MoveSliderUp(float value)
    {
        focusSlider.value += value;
    }
}
