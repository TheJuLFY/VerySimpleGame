using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Enemies
{
    class Enemy : Person
    {
        public string Name;
        public int Death_effect;

        public Enemy(string name, int hp, int damage, int death_effect) : base(hp, damage)
        {
            Name = name;
            Death_effect = death_effect;
        }
    }
}
