using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class SlotController : MonoBehaviour
{
    public int slotID { private set; get; }

    public void Init(int _id)
    {
        
        slotID = _id;
        
    }

}