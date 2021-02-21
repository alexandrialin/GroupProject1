using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InterfaceRemoval : MonoBehaviour
{
    public GameObject ContinueButton;

    public GameObject UI;

    private int count = 0;
    
    public void removeUI()
    {
        Debug.Log(count);
        
        if(count == 2)
        {
            UI.SetActive(false);
        }
        else
        {
            count++;
        }
    }

}
