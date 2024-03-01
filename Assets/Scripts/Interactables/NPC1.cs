using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPC1 : InteractableObject
{
    [SerializeField] private Dialogue[] dialogue;
    private int currentID = -1;

    private UIDialogue uiDialogue;

    private void Awake()
    {
        uiDialogue = FindObjectOfType<UIDialogue>();
    }

   public override void Interact()
    {
       if(dialogue != null && isReach && currentID + 1 < dialogue.Length)
       { 
        currentID++;
        uiDialogue.SetDialogue(dialogue[currentID]);
       } else {
        currentID = -1;
        uiDialogue.CloseDialogue();
        }
    }
}
