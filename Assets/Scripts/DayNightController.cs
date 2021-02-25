using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    public Camera myCamera;
    bool isDay = true;
    public GameObject sun;
    Color dayColor = new Color(.2877f, .5647f,1f);
    Color nightColor = new Color();


    public void SetDay() {
        myCamera.backgroundColor = dayColor;
    }

    public void SetNight() {
        myCamera.backgroundColor = nightColor;
    }
}
