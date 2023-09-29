using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
    public int woodamount;
    public TextMeshProUGUI woodtext;

    public void Awake()
    {
        woodtext.text = "Collisions detected: " + woodamount;
    }

    public void AddWood()
    {
        woodamount++;
        woodtext.text = "Collisions detected: " + woodamount;
    }

    private void OnEnable()
    {
        wood.woodEvent += AddWood;

    }

    private void OnDisable()
    {
        wood.woodEvent -= AddWood;
    }
}
