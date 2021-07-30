using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Heroes
{
    class Hero : Person
    {
        public string Name;
        public double HP_bonus;
        public double Damage_bonus;
        public int Money;

        public Hero(string name, int hp, double hp_bonus, int damage, double damage_bonus, int money) : base(hp, damage)
        {
            Name = name;
            HP_bonus = hp_bonus;
            Damage_bonus = damage_bonus;
            Money = money;
        }
    }
}
