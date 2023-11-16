using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Main 
{
    private List<Inventory_Item> itemList;

    // constructor for the class
    public Inventory_Main() {
        itemList = new List<Inventory_Item>(); // initialize the list
        Debug.Log("Inventory was initialized");

        // elements that are initialized in the inventory
        AddItem(new Inventory_Item {itemType = Inventory_Item.InventoryItemType.coin, quantity = 1 });

    }

    public void AddItem(Inventory_Item item) {
        itemList.Add(item); // add the element to the list

        // we could add grouping elements

    }

    public List<Inventory_Item> GetItemList() {
        return itemList;
    }
}
