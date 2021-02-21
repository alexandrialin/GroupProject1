
using System;

public class TimeWheel
{
    private float minuteWheel;
    private float secondsWheel;
    private bool first_run;

    public TimeWheel(float start_min, float start_seconds)
    {
        this.minuteWheel = start_min;
        this.secondsWheel = start_seconds;
        this.first_run = true;
    }

    public void rollDown()
    {
        this.first_run = false;
        if (minuteWheel == 0 && secondsWheel == 0)
        {
            throw new OutOfTimeException();
        }
        if (secondsWheel != 0)
        {
            secondsWheel = secondsWheel - 1;
        }
        if((secondsWheel == 0) && (minuteWheel != 0)){
            minuteWheel = minuteWheel - 1;
            secondsWheel = 59f;
        }  
    }

    public bool isFirstRun()
    {
        return first_run;
    }

    public String toString()
    {
        return minuteWheel + ":" + secondsWheel;
    }
}

