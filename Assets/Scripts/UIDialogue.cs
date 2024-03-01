using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Canvas))]

public class UIDialogue : MonoBehaviour
{
 [SerializeField] private TextMeshProUGUI contentText;

 private Canvas canvas;

 private void Awake() {
    canvas = GetComponent<Canvas>();
    CloseDialogue();
 }

public void SetDialogue(string _content)
{
canvas.enabled = true;

contentText.text = _content;
}

public void CloseDialogue()
{
    canvas.enabled = false;
}

}
