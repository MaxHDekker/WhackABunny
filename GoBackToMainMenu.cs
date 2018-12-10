using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackToMainMenu : MonoBehaviour
{


    public float times = 2f;


    void Update()
    {
        times -= Time.deltaTime;
        if (Input.touchCount == 1 && times <= 0 || Input.GetMouseButtonDown(0) && times <= 0)
        {
            Application.LoadLevel(0);
        }
        if (times <= 0)
        {
            times = 0;
        }
    }
}