using UnityEngine;

[CreateAssetMenu(fileName = "KillPlayerItem", menuName = "Items/Kill Player")]
public class KillPlayerItem : ItemData
{
    public override void Use(PlayerController player)
    {
        player.TotalHP = 0;
    }
}
