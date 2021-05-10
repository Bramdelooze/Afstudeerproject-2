using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Productivitybar : MonoBehaviour
{
    public Slider productivitySlider;

    public void MoveSliderUp(float value)
    {
        productivitySlider.value += value;
    }
}
