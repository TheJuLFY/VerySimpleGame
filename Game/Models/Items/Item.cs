using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Items
{
    class Item
    {
        public string Name;
        public double HP_bonus;
        public double Damage_bonus;
        public int Price;

        public Item(string name, double hp_bonus, double damage_bonus, int price)
        {
            Name = name;
            HP_bonus = hp_bonus;
            Damage_bonus = damage_bonus;
            Price = price;
        }
    }
}
