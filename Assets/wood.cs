using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ShootingButton;

public class wood : MonoBehaviour

{
    public delegate void WoodEvent();
    public static WoodEvent woodEvent;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("area"))
        {
            woodEvent?.Invoke();
        }

    }
}
