using UnityEngine;
using NaughtyAttributes;

public abstract class ItemData : ScriptableObject
{
    [Header("General Info")]
    public string ItemName;
    public Sprite Image;

    public abstract void Use(PlayerController player);
}
