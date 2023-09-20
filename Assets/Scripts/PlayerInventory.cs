using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<string> inventory = new List<string>(); //create the list 
   
    //adding items to the inventory
    public void AddToInventory(string itemTag)
    {
        inventory.Add(itemTag);
    }

    //removing items from the inventory
    public void RemoveFromInventory(string itemTag)
    {
        inventory.Remove(itemTag);
    }

    //checking if the player has that specific item
    public bool HasItem(string itemTag)
    {
        return inventory.Contains(itemTag);
    }
}


