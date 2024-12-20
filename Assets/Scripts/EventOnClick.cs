using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOnClick : MonoBehaviour
{
    public static event Action ButtonToggle;  

    public void InvokeButtonToggle()
    {
        ButtonToggle?.Invoke();
    }
}
