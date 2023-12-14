using UnityEngine;

[CreateAssetMenu(fileName = "StatData", menuName = "Stat", order = 0)]
public class UserData : ScriptableObject
{
    public string UserID;

    public string Species;
    public string Name;
    public string Description;

    public int Level;
    public int MaxExp;
    public int Exp;
    public int Meat;

    public int Atk;
    public int Def;
    public int MaxHp;
    public int Hp;
    public int MaxMp;
    public int Mp;
    public int CritPercent;
    public int Speed;
}
