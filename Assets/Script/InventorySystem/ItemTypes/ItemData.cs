using UnityEngine;
using NaughtyAttributes;

public abstract class ItemData : ScriptableObject
{
    [Header("General Info")]
    public string ItemName;
    public Sprite Image;

    // Every item decides what happens when used
    public abstract void Use(PlayerController player);
}
