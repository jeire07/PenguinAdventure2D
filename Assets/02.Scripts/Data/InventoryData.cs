using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Data/GameData", order = 2)]
public class InventoryData : ScriptableObject
{
    public ItemData[] MyItems;
}
