using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType.Models
{
    internal abstract class Food
    {
        int Calorie { get; set; }
        protected Food(int calorie)
        {
            Calorie = calorie;      
        }
    }
}
