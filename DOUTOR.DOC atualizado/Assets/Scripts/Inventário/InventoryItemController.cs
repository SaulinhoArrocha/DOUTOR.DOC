using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    public Item item;

    public Button RemoveButton;

    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);

        Destroy(gameObject);
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
    }


    public void UseItem()
    {
        switch (item.itemType)
        {
            case Item.ItemType.Envelope:
                Player.Instance.UsarEnvelope();
                break;
            case Item.ItemType.Hemaglutinina:
                Player.Instance.UsarHemaglutinina();
                break;
            case Item.ItemType.ProteinaM:
                Player.Instance.UsarProteinaM();
                break;
            case Item.ItemType.ProteinaSpike:
                Player.Instance.UsarProteinaSpike();
                break;
            case Item.ItemType.Rna:
                Player.Instance.UsarRna();
                break;
        }

        RemoveItem();
    }
}
