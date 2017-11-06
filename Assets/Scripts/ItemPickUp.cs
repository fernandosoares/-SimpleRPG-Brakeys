using UnityEngine;

public class ItemPickUp : Interactable {

    public Item item;

    public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Pickng up " + item.name);

        Inventory.instance.Add(item);

        // Remove it from the scene
        Destroy(gameObject);
    }
}
