using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterInfos : MonoBehaviour
{
    
    public int moneyCount = 0;
    private int maxHealth = 5;
    public int health = 5;

    [SerializeField] private Transform heartPrefab;
    [SerializeField] private Transform heartParent;
    private List<GameObject> heartsObj = new List<GameObject>();

    private GameManager manager;
    [SerializeField] private TextMeshProUGUI moneyTxt;

    private void Start()
    {
        manager = GameManager.GetInstance();

        InitHealth();
    }

    private void Update()
    {
        moneyTxt.text = " : " + moneyCount;
    }

    private void InitHealth ()
    {
        health = maxHealth;

        for (int i = 0; 1 < maxHealth; i++)
        {
            Transform curHeart = Instantiate(heartPrefab);
            curHeart.SetParent(heartParent);
            heartsObj.Add(curHeart.gameObject);
        }
    }
}
