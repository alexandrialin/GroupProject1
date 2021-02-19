using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PictureScene : MonoBehaviour
{
    public float transitionTime = 1;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Picture1"))
        {
            SceneManager.LoadScene(4);
        }
        if (gameObject.CompareTag("Picture2"))
        {
            SceneManager.LoadScene(6);
        }
        if (gameObject.CompareTag("Picture3"))
        {
            SceneManager.LoadScene(8);
        }
        if (gameObject.CompareTag("Picture4"))
        {
            SceneManager.LoadScene(10);
        }
        if (gameObject.CompareTag("restart"))
        {
            SceneManager.LoadScene(10);
        }
        if (gameObject.CompareTag("continue"))
        {
            SceneManager.LoadScene(11);
        }
        if (gameObject.CompareTag("fox"))
        {
            SceneManager.LoadScene(12);
        }
        if (gameObject.CompareTag("door"))
        {
            SceneManager.LoadScene(13);
        }
    }
    
    
}
