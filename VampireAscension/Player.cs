using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Player
{
    private int _hp;
    private string _name = string.Empty;
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

    public void InventoryRemove()
    {

    }

}