using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPath : MonoBehaviour{
    public static float previous;
    public static bool firstrun = true;

    public static float startPathZ(float time){
        //1/x function
        return 2f / time; 
    }

    public static float startPathRotationX(float time){
        float slope;
        float rad;
        float newAngle;
        float previousPlace;

        if (firstrun){
            slope = (2f / Mathf.Pow(time, 2));
            rad = Mathf.Atan(slope);
            newAngle = (rad * (180 / Mathf.PI));
            previous = newAngle;
            firstrun = false;
            return newAngle;
        }
        else
        {
            slope = (2f / Mathf.Pow(time, 2));
            rad = Mathf.Atan(slope);
            newAngle = (rad * (180 / Mathf.PI));
            previousPlace = previous;
            previous = newAngle;
        }
        
        return newAngle - previousPlace;
    }


    public static bool isCompleted(float time){

        if(time >= 5f)
        {
            return true;
        }
         
        return false;
    }

}
