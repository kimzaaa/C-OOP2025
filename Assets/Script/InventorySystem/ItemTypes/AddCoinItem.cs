using UnityEngine;

[CreateAssetMenu(fileName = "AddCoinItem", menuName = "Items/Add Coin")]
public class AddCoinItem : ItemData
{
    [Min(1)] public int CoinToIncrease = 1;

    public override void Use(PlayerController player)
    {
        player.TotalMoney += CoinToIncrease;
    }
}
    