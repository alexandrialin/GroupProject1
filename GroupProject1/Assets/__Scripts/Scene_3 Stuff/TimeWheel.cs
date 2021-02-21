
using System;

public class TimeWheel
{
    private float minuteWheel;
    private float secondsWheel;

    public TimeWheel(float start_min, float start_seconds)
    {
        this.minuteWheel = start_min;
        this.secondsWheel = start_seconds;
    }

    public void rollDown()
    {
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
    public String toString()
    {
        return minuteWheel + ":" + secondsWheel;
    }
}

