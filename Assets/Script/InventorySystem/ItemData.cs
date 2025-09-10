using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(fileName = "ItemData", menuName = "Scriptable Objects/Create Item Data")]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public Sprite Image;

    [ShowIf("isAddCoin")]
    public int CoinToIncrease;
    [ShowIf("isAddHp")]
    public int HpToIncrease;

    public Type type;

    public enum Type
    {
        AddHp,
        AddCoin,
        KillPlayer
    }

    private bool isAddCoin => type == Type.AddCoin;
    private bool isAddHp => type == Type.AddHp;

    public void Use(Inventory inventory)
    {
        switch (type)
        {
            case Type.AddCoin:
                inventory.TotalMoney += CoinToIncrease;
                break;
            case Type.AddHp:
                inventory.TotalHP += HpToIncrease;
                break;
            case Type.KillPlayer:
                Object.Destroy(inventory.Player);
                break;
        }
    }
}
