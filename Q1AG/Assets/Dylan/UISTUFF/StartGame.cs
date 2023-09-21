using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject DiaSystem;
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();
        DiaSystem.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        DiaSystem.SetActive(true);
        nameText.text = dialogue.name;
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

    }
    void EndDialogue()
    {
        Debug.Log("End of Conversation");
        DiaSystem.SetActive(false);
    }
}
