using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : InteractableObject
{

    [SerializeField] private string dialogue;

    private UIDialogue uiDialogue;

    private void Awake()
    {
        uiDialogue = FindObjectOfType<UIDialogue>();
    }

   public override void Interact()
    {
       if(isReach) uiDialogue.SetDialogue(dialogue);
       else uiDialogue.CloseDialogue();
    }
}
