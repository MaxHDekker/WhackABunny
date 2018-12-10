using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndScore : MonoBehaviour {

    // Use this for initialization
    Text text;
	
    void Awake()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        text.text = "You Scored!: " + Score.score;	
	}
   
}
