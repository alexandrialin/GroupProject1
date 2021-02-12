using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    private Queue<string> mirthalSentences;
    
    // Start is called before the first frame update
    void Start()
    {
        mirthalSentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {

        Debug.Log("Starting conversation with Merthal " + dialogue.name);

        nameText.text = dialogue.name;

        mirthalSentences.Clear();

        foreach (string mirthalSentence in dialogue.mirthalSentences)
        {
            mirthalSentences.Enqueue(mirthalSentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (mirthalSentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string mirthalSentence = mirthalSentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(mirthalSentence));
    }

    IEnumerator TypeSentence (string mirthalSentence)
    {
        dialogueText.text = "";
        foreach (char letter in mirthalSentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }

}
