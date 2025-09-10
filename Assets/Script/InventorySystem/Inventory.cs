using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<ItemData> itemDatas = new List<ItemData>();
    public int TotalMoney = 0;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TotalMoney += itemDatas[0].CoinToIncrease;
            itemDatas.Remove(itemDatas[0]);
        }
    }
}
