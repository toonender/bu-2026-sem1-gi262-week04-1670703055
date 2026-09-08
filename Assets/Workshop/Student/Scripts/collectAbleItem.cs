using UnityEngine;

namespace Solution
{
    public class CollectAbleItem : Identity
    {
        public override bool Hit()
        {
            Debug.Log("Item: " + Name + " has been picked up.");
            // ทำลายไอเท็มออกจากฉาก

            Destroy(gameObject);
            mapGenerator.player.inventory.AddItem(Name, 1);
            return true;
        }
    }
}

