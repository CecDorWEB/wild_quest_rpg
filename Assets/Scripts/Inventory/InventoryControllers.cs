using UnityEngine;

[RequireComponent(typeof(InventoryData), typeof(InventoryDisplay))]

public class InventoryController : MonoBehaviour
{
    private InventoryData data;
    private InventoryDisplay display;

    

    private void Start()
    {
        data = GetComponent<InventoryData>();
        display = GetComponent<InventoryDisplay>();

    }

   
    public int SlotNumber => data.SlotNumber;
}