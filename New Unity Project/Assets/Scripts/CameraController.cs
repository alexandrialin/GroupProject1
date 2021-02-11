using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{

    public GameObject camera;


    void Update(){

        float time = Time.time + 0.067f;
        
        
       // Debug.Log(time);
        
        if (!CameraPath.isCompleted(time)){

            camera.transform.position = new Vector3(0.0f, CameraPath.startPathZ(time), 0.0f);
            camera.transform.Rotate(CameraPath.startPathRotationX(time), 0,0);
        }
    }
}

