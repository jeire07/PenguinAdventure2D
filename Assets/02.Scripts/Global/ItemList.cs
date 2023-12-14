using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    public static ItemList Instance { get; private set; }

    public List<Item> Items { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Items = new List<Item>();
        CreateItemList();
    }

    void CreateItemList()
    {
        Items.Add(new Item("Green Staff", "cheap staff", 1, 0, 0, 0, 1000));
        Items.Add(new Item("Red Staff", "expensive staff", 0, 5, 0, 0, 2000));
        Items.Add(new Item("Red Gem Sword", "nice sword", 0, 0, 0, -10, 1000));
        Items.Add(new Item("Shield", "iron shield", -5, 0, 0, 0, 500));
        Items.Add(new Item("Healing potion", "can recover health", 0, 0, 0, 0, 100));
        Items.Add(new Item("Healing potion", "can recover health", 0, 0, 0, 0, 200));
    }
}
