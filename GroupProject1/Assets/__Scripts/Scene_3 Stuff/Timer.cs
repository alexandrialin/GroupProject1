using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private TimeWheel wheel;
    private float deltatime = 0;

    public float start_min;
    public float start_seconds;

    public GameObject textbackground;
    public TextMeshProUGUI timer;
    public Text finished_banner;
        
    void Start()
    {
        wheel = new TimeWheel(start_min, start_seconds);
    }

    // Update is called once per frame
    void Update()
    {
        if (textbackground.activeSelf == false)
        {
            deltatime = deltatime + Time.deltaTime;

            if (deltatime >= 1)
            {
                deltatime = 0; 
                try
                {
                    timer.text = wheel.toString();
                    wheel.rollDown();
                }
                catch (OutOfTimeException ex)
                {
                    
                    finished_banner.text = "Out Of Time!";
                }
            }
        }
    }
}
