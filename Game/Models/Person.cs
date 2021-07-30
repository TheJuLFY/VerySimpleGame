using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    class Person
    {
        public int HP;
        public int Damage;
        public static int count = 0;

        public Person(int hp, int damage)
        {
            HP = hp;
            Damage = damage;
            count++;
        }

        public void Attack(Person target)
        {
            target.HP -= Damage;
        }
    }
}
