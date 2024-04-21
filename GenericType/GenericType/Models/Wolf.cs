using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType.Models
{
    internal class Wolf : Animal 
    {
        bool IsPrideLeader;
        int AttackDamage;

        public Wolf(int avgLifeTime, string breed, int hp, Gender gender, bool isPrideLeader,int attackDamage ) : base (avgLifeTime, breed, hp, gender)
        {
            AttackDamage = attackDamage;
            IsPrideLeader = isPrideLeader;
        }


        public void Hunt<T>(T animal) where T : Animal
        {
            Console.WriteLine("animal hp before hunting "+ animal.HP );
            animal.HP -= AttackDamage;
            Console.WriteLine("animal hp after hunting " + animal.HP);
        }

    }
}
