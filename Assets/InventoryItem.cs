using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItem : MonoBehaviour
{
    public string itemName;     // Name of the item
    public Sprite icon;         // Icon to display in the inventory UI
    public ItemType itemType;   // Category of the item (e.g., Health, Weapon, Bonus)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
