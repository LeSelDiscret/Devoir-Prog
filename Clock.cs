using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float HourstoDegrees = -30, MinutesToDegrees = -6f, SecondsToDegrees = -6f;
    
    [SerializeField]
    Transform HoursPivot, MinutesPivot, SecondsPivot;
    
    private void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        
        HoursPivot.localRotation = Quaternion.Euler(0, 0, HourstoDegrees * (float)time.TotalHours);

        MinutesPivot.localRotation = Quaternion.Euler(0, 0, MinutesToDegrees * (float)time.TotalMinutes);
        
        SecondsPivot.localRotation = Quaternion.Euler(0, 0, SecondsToDegrees * (float)time.TotalSeconds);
        //titouan est trop cool//
    }
}
