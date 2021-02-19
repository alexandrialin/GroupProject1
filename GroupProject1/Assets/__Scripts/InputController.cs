using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputController : MonoBehaviour
{
    [SerializeField]
    private InputField input;
    [SerializeField]
    private Text text;
    private string word;
    private int guessNumber;

    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Picture1")
        {
            word = "painting";

        }
        if (sceneName == "Picture2")
        {
            word = "hercules";

        }
        if (sceneName == "Picture3")
        {
            word = "betrayal";
        }
        input = GameObject.Find("InputField").GetComponent<InputField>();
    }
    
    public void GetInput(string guess)
    {
        
        CompareGuesses(guess);
        input.text = "";
        
    }
    void CompareGuesses(string guess)
    {
        
        if (word == guess)
        {
            if (word == "painting")
            {
                SceneManager.LoadScene(5);

            }
            if (word == "hercules")
            {
                SceneManager.LoadScene(7);

            }
            if (word == "betrayal")
            {
                SceneManager.LoadScene(9);

            }

        }
        else
        {
            text.text = "Try Again";
        }
        
    }
}
