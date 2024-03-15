using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;
    void Update()
    {
        var time = DateTime.Now;
        if(hoursPivot != null)
            hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
        if(minutesPivot != null)
            minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
        if(secondsPivot != null)
            secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }
}
