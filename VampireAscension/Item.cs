using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VampireAscension
{
    public class Item
    {
        string _name { get; set; }
        string _description { get; set; }
        string _type { get; set; }
        string _typeDescription { get; set; }
        int _damage { get; set; }
        int _value { get; set; }

        public Item(string name, string description, string type, string typeDescription, int damage, int value)
        {
            _name = name;
            _description = description;
            _type = type;
            _typeDescription = typeDescription;
            _damage = damage;
            _value = value;
        }
    }
}