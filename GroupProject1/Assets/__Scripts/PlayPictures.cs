using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayPictures : MonoBehaviour
{

    public RawImage hometownImage;
    public RawImage waterfallImage;
    public GameObject textDisplay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisplayImage());
    }

    IEnumerator DisplayImage()
    {
        hometownImage.enabled = true;
        yield return new WaitForSeconds(3);
        hometownImage.enabled = false;

        waterfallImage.enabled = true;
        textDisplay.SetActive(true);
        yield return new WaitForSeconds(5);
        waterfallImage.enabled = false;
        textDisplay.SetActive(false);
        
    }
}
