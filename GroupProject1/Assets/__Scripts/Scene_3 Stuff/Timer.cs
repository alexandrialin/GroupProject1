using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private TimeWheel wheel;
    private float deltatime = 0;


    public GameObject textbackground;
    public TextMeshProUGUI timer;
    public Text finished_banner;
        
    void Start()
    {
        wheel = new TimeWheel(0f,10f);
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
                    wheel.rollDown();
                    timer.text = wheel.toString();
                    Debug.Log(wheel.toString());
                }
                catch (OutOfTimeException ex)
                {
                    timer.text = wheel.toString();
                    finished_banner.text = "Out Of Time!";
                }
            }
        }
    }
}
