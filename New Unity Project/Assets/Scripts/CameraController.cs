using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camera;
    public float stretch;
    public float maxTime;

    private CameraPath path;

    void Start()
    {
        path = new CameraPath(stretch, camera.transform.position.y, maxTime);
    }

    void Update()
    {   
        if (!path.isCompleted()){
            path.updateTime(Time.time);
            camera.transform.position = new Vector3(0.0f, path.pathZ(), 0.0f);
            camera.transform.Rotate(path.pathRotationX(), 0f, 0f);
        }
    }
}