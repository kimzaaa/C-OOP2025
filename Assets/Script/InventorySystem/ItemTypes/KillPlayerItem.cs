using UnityEngine;

[CreateAssetMenu(fileName = "KillPlayerItem", menuName = "Items/Kill Player")]
public class KillPlayerItem : ItemData
{
    public override void Use(PlayerController player)
    {
        // Option A: custom death logic
        // player.Die();

        // Option B: just set HP = 0
        player.TotalHP = 0;
    }
}
