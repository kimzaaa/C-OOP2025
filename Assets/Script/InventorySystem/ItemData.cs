using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Scriptable Objects/Create Item Data")]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public Sprite Image;
    public int CoinToIncrease;
}
