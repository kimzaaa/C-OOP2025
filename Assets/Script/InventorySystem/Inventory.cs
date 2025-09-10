using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<ItemData> itemDatas = new List<ItemData>();
    public List<GameObject> Slots = new List<GameObject>();
    public GameObject Highlighter;

    public int TotalMoney = 0;
    public int TotalHP = 100;

    private int index = 0;
    private Slots slot;
    private GameObject _player;

    public GameObject Player => _player;

    void Start()
    {
        _player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        UpdateSlot();

        if (Input.GetKeyDown(KeyCode.E))
        {
            itemDatas[index].Use(this);
            itemDatas[index] = null;
        }

        if (Input.mouseScrollDelta.y != 0)
        {
            if (Input.mouseScrollDelta.y < 0)
            {
                index++;
                if (index >= Slots.Count) index = 0;
            }
            else if (Input.mouseScrollDelta.y > 0)
            {
                index--;
                if (index < 0) index = Slots.Count - 1;
            }

            Highlighter.transform.position = Slots[index].transform.position;
        }

    }

    void UpdateSlot()
    {
        for (int i = 0; i < Slots.Count; i++)
        {
            slot = Slots[i].GetComponent<Slots>();

            if (i < itemDatas.Count)
            {
                slot.SlotData = itemDatas[i];
            }
            else
            {
                slot.SlotData = null;
            }
        }
    }
}
