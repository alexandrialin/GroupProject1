using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Pass into dialogueManager when you want to display a new message

[System.Serializable]
public class Dialogue
{
    public string name;

    [TextArea(1,20)]
    public string[] mirthalSentences;
}
