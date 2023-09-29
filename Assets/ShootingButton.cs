using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingButton : MonoBehaviour
{
    public delegate void ShootingEvent();
    public static ShootingEvent shootingEvent;

    public void ShootButton()
    {
        shootingEvent?.Invoke();
    }


}
