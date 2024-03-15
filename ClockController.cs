using System;
using UnityEngine;
public class ClockController : MonoBehaviour
{
const float secondsToDegrees = -6f;
public Transform secondsPivot;
void Update()
{
var time = DateTime.Now;
if (secondsPivot != null)
secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees *
time.Second);
}
}