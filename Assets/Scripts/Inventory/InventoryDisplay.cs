using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{

    private SlotController[] slots;

    [SerializeField] private Transform slotPrefab;

    [SerializeField] private Transform slotParent;
    private InventoryController controller;

    public void Init(InventoryController _controller)
    {
        controller = _controller;

        slots = new SlotController[controller.SlotNumber];
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = Instantiate(slotPrefab, transform.position, Quaternion.identity, slotParent).GetComponent<SlotController>();
            slots[i].Init(i);
        }
    }

}
