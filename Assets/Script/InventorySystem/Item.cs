using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemData itemData;

    private string _itemName;
    private Inventory inventory;

    void Start()
    {
        _itemName = itemData.ItemName;

        GameObject player = GameObject.Find("InventoryManager");
        inventory = player.GetComponent<Inventory>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bool placed = false;
            for (int i = 0; i < inventory.itemDatas.Count; i++)
            {
                if (inventory.itemDatas[i] == null)
                {
                    inventory.itemDatas[i] = itemData;
                    placed = true;
                    break;
                }
            }
            if (!placed)
            {
                inventory.itemDatas.Add(itemData);
            }

            Destroy(gameObject);
        }
    }

}
