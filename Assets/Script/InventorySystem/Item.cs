using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemData itemData;

    private string _itemName;
    private Inventory inventory;

    void Start()
    {
        _itemName = itemData.ItemName;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<Inventory>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inventory.itemDatas.Add(itemData);
            Destroy(gameObject);
        }
    }
}
