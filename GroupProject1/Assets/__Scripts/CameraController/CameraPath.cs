using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPath
{
    private float previous;
    private bool firstrun;
    private float stretch;
    private float starting_time;
    private float time;
    private float max_time;

    public CameraPath(float stretch, float starting_height, float max_time)
    {
        this.firstrun = true;
        this.starting_time = stretch / starting_height; 
        this.stretch = stretch;
        this.max_time = max_time;
    }

    public float pathZ()
    {
        //1/x function
        return stretch / time;
    }

    public float pathRotationX()
    {
        //rotation is the angle of the tangent to 1/x at time
        float slope = (stretch / Mathf.Pow(time, 2));
        float rad = Mathf.Atan(slope);
        float newAngle = (rad * (180 / Mathf.PI));
        
        float previousholder = previous;
        previous = newAngle;
        
        if (firstrun)
        {
            firstrun = false;
            return newAngle;
        }
        else
        {
            return newAngle - previousholder;
        }
    }

    public void updateTime(float time)
    {
        this.time = time + starting_time;
    }

    public bool isCompleted()
    {

        if (time >= max_time)
        {
            return true;
        }
        return false;
    }
}
