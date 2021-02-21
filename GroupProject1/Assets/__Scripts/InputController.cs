using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class InputController : MonoBehaviour 
{
    [SerializeField]
    private InputField input;
    [SerializeField]
    private Text text;
    private string word;
    private int guessNumber;
    public Button yourButton;
    
    void Awake()
    {
        
        
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Picture1")
        {
            word = "painting";
            input = GameObject.Find("InputField").GetComponent<InputField>();

        }
        if (sceneName == "Picture2")
        {
            word = "hercules";
            input = GameObject.Find("InputField").GetComponent<InputField>();

        }
        if (sceneName == "Picture3")
        {
            word = "betrayal";
            input = GameObject.Find("InputField").GetComponent<InputField>();
        }
        if (sceneName == "Picture1")
        {
            Button btn = yourButton.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);

        }
        if (sceneName == "Fox") 
        {
            Button btn = yourButton.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);

        }
        if (sceneName == "Door")
        {
            word = "3312";
            input = GameObject.Find("InputField").GetComponent<InputField>();
            Button btn = yourButton.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);


        }



    }

    IEnumerator Hesitate()
    {
        text.text = "Sorry you are incorrect";
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(14);
    }

    IEnumerator Hesitate2()
    {
        if (gameObject.CompareTag("earth"))
        {
            text.text = "Congrats! You get a new weapon";
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(14);
        }
    }

    void TaskOnClick()
    {
        if (gameObject.CompareTag("water") || gameObject.CompareTag("fire") || gameObject.CompareTag("air"))
        {
            StartCoroutine(Hesitate());
        }
        if (gameObject.CompareTag("back"))
        {
            SceneManager.LoadScene(14);
        }

        if (gameObject.CompareTag("earth"))
        {
            StartCoroutine(Hesitate2());
        }
        if (gameObject.CompareTag("hint1"))
        {
        }
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
            if (word == "3312")
            {
                SceneManager.LoadScene(15);

            }

        }
        else
        {
            text.text = "Try Again";
        }
    
        
    }
    
}
