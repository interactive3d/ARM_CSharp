using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Item 
{
    // enum - list of possible elements
    public enum InventoryItemType {
        coin,
        box,
        sphere,
    }

    public InventoryItemType itemType; // access to the elements
    public int quantity; // amount of the elements

}
