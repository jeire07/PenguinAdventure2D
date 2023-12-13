using System.Collections.Generic;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public static PlayerStat Instance { get; private set; }

    public string Name { get; set; }
    public string Job { get; set; }
    public int Level { get; set; }
    public float Atk { get; set; }
    public int Def { get; set; }
    public int HP { get; set; }
    public int MaxHP { get; set; }
    public int MP { get; set; }
    public int MaxMP { get; set; }
    public int Gold { get; set; }
    public bool IsAlive { get; set; }
    public int Exp { get; set; }
    public int MaxExp { get; set; }

    public List<Item> Inventory { get; private set; }
    public PlayerStat Player { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // 중복 인스턴스가 생성될 경우 제거
        }
    }

    private void Start()
    {
        Name = "Sir. Penguin";
        Job = "Penguin";
        Level = 1;
        Atk = 0;
        Def = 0;
        HP = 100;
        MaxHP = 100;
        MP = 50;
        MaxMP = 50;
        Gold = 5000;
        IsAlive = true;
        Exp = 0;
        MaxExp = 10;
    }

    public void LevelUp()
    {
        Level++;
        Exp -= MaxExp;
        MaxExp *= 2;
    }
}
