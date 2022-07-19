using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryElements : MonoBehaviour
{
    public Dialogue dialogue;
    public void Trigger() {
        FindObjectOfType<DialogSystem>().StartDialogue(dialogue);
    }
}
