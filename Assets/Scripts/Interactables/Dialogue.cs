using UnityEngine;


[System.Serializable]
public class Dialogue
{
[SerializeField] private string charName;
[SerializeField, TextArea(1,5)] private string content;
[SerializeField] private Sprite charSprite;

public string getCharName => charName;
public string getContent => content;
public Sprite getCharSprite => charSprite;
}