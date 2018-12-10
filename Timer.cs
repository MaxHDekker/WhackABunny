using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 50f;
    Text text;
    // Use this for initialization
    void Start()
    {

    }
    void Awake()
    {
        text = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {

        text.text = "Time left: " + Mathf.RoundToInt(time % 60);
        time -= Time.deltaTime;

        if (time <= 0)
        {
            Application.LoadLevel(2);
        }
        
        if(time <= 5.5)
        {
            text.color = Color.red;
        }
    }
}