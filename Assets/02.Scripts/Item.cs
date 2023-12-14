public class Item
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int HP { get; private set; }
    public int MP { get; private set; }
    public int Cost { get; private set; }

    public Item(string name, string description, int atk, int def, int hp, int mp, int cost)
    {
        Name = name;
        Description = description;
        Atk = atk;
        Def = def;
        HP = hp;
        MP = mp;
        Cost = cost;
    }
}
