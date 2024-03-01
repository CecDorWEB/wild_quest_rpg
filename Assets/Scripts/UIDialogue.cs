using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Canvas))]

public class UIDialogue : MonoBehaviour
{
 [SerializeField] private TextMeshProUGUI contentText;
 [SerializeField] private Image charImage;

 private Canvas canvas;

 private void Awake() {
    canvas = GetComponent<Canvas>();
    

    CloseDialogue();
 }

public void SetDialogue(Dialogue _dialogue)
{
canvas.enabled = true;

contentText.text = _dialogue.getCharName + " : " + _dialogue.getContent;
charImage.sprite = _dialogue.getCharSprite;

}

public void CloseDialogue()
{
    canvas.enabled = false;
}

}
