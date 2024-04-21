using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType.Models
{
    internal class Elephant : Animal
    {
        double Weight;
        bool IsTrained;

        public Elephant(int avgLifeTime, string breed, int hp, Gender gender , double weight,bool isTrained) : base(avgLifeTime, breed, hp, gender)
        {
            Weight = weight;
            IsTrained = isTrained;
        }
    }
}
