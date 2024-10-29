using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewHealthItem", menuName = "Inventory/Health Item")]
public class WeaponItem : InventoryItem
{
    public int damage;
    public int ammoCount;

    private void OnEnable()
    {
        itemType = ItemType.Weapon;
    }
}
