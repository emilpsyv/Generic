using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType.Models
{
    internal abstract class Animal 
    {
       public int AvgLifeTime;
       public string Breed;
       public int HP;
       public Gender Gender;
        int defaultHp;
       

       

        protected Animal(int avgLifeTime, string breed, int hp, Gender gender)
        {
            AvgLifeTime = avgLifeTime;
            Breed = breed;
            HP = hp;
            Gender = gender;
            defaultHp = hp;
        }
        public void Feed()
        {
            if (HP + 10 >= defaultHp)
            { Console.WriteLine("hp is full"); HP = defaultHp; }
            else { Console.WriteLine("Health points restored from "+HP +" to "+( HP + 10)); HP = HP + 10;  }


        }
       
    }
}

namespace GenericType
{
    public enum Gender
    {
        male,
        female
    }
}