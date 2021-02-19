using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class Points : MonoBehaviour
{

    [SerializeField]
    private Text text1;
    [SerializeField]
    private Text text2;
    public Button yourButton;
    private int points;
    private int weapon;

    void Awake()
    {


        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Picture1")
        {
            points = 110;
            weapon = 0;
        }
        if (sceneName == "Picture1"||sceneName == "Picture2"||sceneName == "Picture3"||sceneName=="Fox")
        {
            Button btn = yourButton.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);

        }
        if (sceneName == "Stats")
        {
            text1.text = "Congratulations! You win";
            text2.text = points + " Health Points Overall";
            if (weapon == 1)
            {
                text2.text = points + " Health Points Overall \n You have obtained a bonus weapon!";
            }


        }
    }
    void TaskOnClick()
    {
        if (gameObject.CompareTag("hint1"))
        {
            points = points - 2;
            text1.text = "Use binary to decrypt numbers, and use numbers to translate to words"+points;
        }
        if (gameObject.CompareTag("hint2"))
        {
            points = points - 2;
            text1.text = "Son of God of Lightning, half human half God"+points;
        }
        if (gameObject.CompareTag("hint3"))
        {
            points = points - 2;
            text1.text = "Go through the maze and see what word it spells";
        }
        if (gameObject.CompareTag("earth"))
        {
            weapon = 1;
        }
    }
}
