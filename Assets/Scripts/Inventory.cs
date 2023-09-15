using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<string> inventory = new List<string>(); //Create the list 
   
    //Adding items to the inventory
    public void AddToInventory(string itemTag)
    {
        inventory.Add(itemTag);
    }

    //Removing items from the inventory
    public void RemoveFromInventory(string itemTag)
    {
        inventory.Remove(itemTag);
    }

    //Checking if the player has that specific item
    public bool HasItem(string itemTag)
    {
        return inventory.Contains(itemTag);
    }
}


