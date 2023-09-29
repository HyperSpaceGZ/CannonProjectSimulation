using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CannonScript : MonoBehaviour
{
    public Slider CannonSlider;
    public Transform Cannon;
    public Slider BaseSlider;

    public TextMeshProUGUI xText;
    public TextMeshProUGUI yText;
    void Update()
    {
        float CannonRotate = CannonSlider.value;
        float BaseRotation = BaseSlider.value;
        Cannon.rotation = Quaternion.Euler(CannonRotate, BaseRotation, 0f);
        
        xText.text = "" + CannonSlider.value;
        yText.text = "" + BaseSlider.value;
    }


}
