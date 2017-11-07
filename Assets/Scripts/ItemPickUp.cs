using UnityEngine;

public class ItemPickUp : Interactable
{

    public Item item;

    public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    void PickUp()
    {
        bool wasPickedUp = Inventory.instance.Add(item);

        if (wasPickedUp)
        {
            Debug.Log("Pickng up " + item.name);
            Destroy(gameObject);
        }
    }
}
