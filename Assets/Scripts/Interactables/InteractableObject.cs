using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public abstract class InteractableObject : MonoBehaviour
{
    protected bool isReach = false;

    protected bool open = false;

    protected GameManager manager;

    private void Start()
    {
        manager = GameManager.GetInstance();

        InputsManager.instance.interactionEvent.AddListener(Interact);
    }

public abstract void Interact();
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("poulet");
        if (collision.gameObject.tag == "Player")
        {
            isReach = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isReach = false;
            open = false;
            Interact();

        }
    }

}
