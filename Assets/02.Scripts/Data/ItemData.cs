using UnityEngine;

[CreateAssetMenu(fileName = "ItemData_", menuName = "Data/ItemData", order = 1)]
public class ItemData : ScriptableObject
{
    public string Name;
    public string Description;
    public int Atk;
    public int Def;
    public int Hp;
    public int Mp;
    public int CritPercent;
    public int Speed;
    public int Price;
    public bool IsEquipped;
    public Sprite Image;
}
