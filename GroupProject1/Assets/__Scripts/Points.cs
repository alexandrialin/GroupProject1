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
    public static int points;
    public static int weapon;

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
            text1.text = "Round 1 Stats:";
            if (weapon == 0)
            {
                text2.text = (points - 100) + " points this round \n\nYou have " + points + " health points overall";
            }
            if (weapon == 1)
            {
                text2.text = (points - 100) + " points this round \n\nYou have " + points + " health points overall \n\n You have obtained a bonus weapon!";
            }
        }
    }
    void TaskOnClick()
    {
        if (gameObject.CompareTag("hint1"))
        {
            points = points - 2;
            text1.text = "Translate binary numbers to letters (A=0, Z=25)";
        }
        if (gameObject.CompareTag("hint2"))
        {
            points = points - 2;
            text1.text = "Son of the God of Lightning, half human half God";
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
