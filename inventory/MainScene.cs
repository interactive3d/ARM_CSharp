using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    private Inventory_Main myInventory;
    
    private void Awake() {
        myInventory = new Inventory_Main(); // initialize the class of inventory
    }

    private void Update() {
        #region Inventory Invoke
        if (Input.GetKeyDown(KeyCode.I)) {
            DisplayCurrentInvenotry();
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            // add element to the inventory
            Debug.Log("elements added to the inventory");
            myInventory.AddItem(new Inventory_Item { itemType = Inventory_Item.InventoryItemType.coin, quantity = 4 });
            myInventory.AddItem(new Inventory_Item { itemType = Inventory_Item.InventoryItemType.box, quantity = 1 });
            myInventory.AddItem(new Inventory_Item { itemType = Inventory_Item.InventoryItemType.sphere, quantity = 5 });
        }
        #endregion

    }
    #region Inventory Helpers

    public void DisplayCurrentInvenotry() {
        Debug.Log("Display current inventory");
        foreach (Inventory_Item item in myInventory.GetItemList()) {
            Debug.Log($"There are {item.quantity} of {item.itemType} in the inventory");
        }
    }
    
    #endregion



}
