using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    public Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;
    void Start()
    {
        sentences = new Queue<string>();
    }
    string end() => "The End Dialogue";
    public void StartDialogue (Dialogue dialogue) {
        Debug.Log("Start conversation " + dialogue.name);
        nameText.text = dialogue.name;
        sentences.Clear();
        foreach (var item in dialogue.sentences) {
            sentences.Enqueue(item);
        }
        NextDialogue();
    }
    public void NextDialogue() {
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(Typing(sentence));

    }
    IEnumerator Typing(string txt) {
        dialogueText.text = "";
        foreach (var letter in txt.ToCharArray()) {
            dialogueText.text += letter;
            yield return null;
        }
    }
    public void EndDialogue() {
        Debug.Log(end());
    }

}
