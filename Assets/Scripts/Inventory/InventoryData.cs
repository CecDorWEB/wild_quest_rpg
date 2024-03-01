using UnityEngine;

public class InventoryData : MonoBehaviour
{
    [SerializeField] private int slotNumber;

 

    private InventoryController controller;

    public void Init(InventoryController _controller)
    {
        controller = _controller;

    }

 

    public int SlotNumber => slotNumber;
    
}
