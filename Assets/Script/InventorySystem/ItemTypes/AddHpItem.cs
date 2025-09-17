using UnityEngine;

[CreateAssetMenu(fileName = "AddHpItem", menuName = "Items/Add HP")]
public class AddHpItem : ItemData
{
    [Min(1)] public int HpToIncrease = 10;

    public override void Use(PlayerController player)
    {
        player.TotalHP += HpToIncrease;
    }
}
