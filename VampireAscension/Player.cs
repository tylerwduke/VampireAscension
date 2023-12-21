using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Player
{
    public int _hp;
    public string _name = string.Empty;
    public List<string> _inventory = new List<string>();

    public Player(int hp, string name)
    {
        _hp = hp;
        _name = name;
    }

    public void InventoryAdd(string item)
    {
        _inventory.Add(item);
    }

    public void InventoryRemove(string item)
    {
        _inventory.RemoveAll(r => r.Equals(item));
    }

    public void LoseHp(int amt)
    {
        _hp -= amt;
    }

    public void GainHp(int amt)
    {
        _hp += amt;
    }
}