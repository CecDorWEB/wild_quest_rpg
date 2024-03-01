using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum ItemID
{
    Money = 0,
}

[System.Serializable]

public class Item
{
    [SerializeField] private string name;

    public ItemID _id;

    public int number = 0;
}

public class CharacterInfos : MonoBehaviour
{

    private static Item[] inventory;
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

        inventory = new Item[1];
        inventory[0] = new Item();

        InitHealth();
    }

    private void Update()
    {
        moneyTxt.text = " : " + inventory[((int)ItemID.Money)].number ;
    }

    private void InitHealth()
    {
        health = maxHealth;

        for (int i = 0; i < maxHealth; i++)
        {
            Transform curHeart = Instantiate(heartPrefab);
            curHeart.SetParent(heartParent);
            heartsObj.Add(curHeart.gameObject);
        }
    }

    private void TakeDamage(int _damage)
    {
        health -= _damage;
        for (int i = 1; i < maxHealth + 1; i++) {

            bool _state = i <= health ? true : false;
            
            heartsObj[i - 1].SetActive(_state);
        }
    }

     public static void AddItem(ItemID _id, int _number)
        {
            inventory[((int)_id)].number += _number;
        }
    }