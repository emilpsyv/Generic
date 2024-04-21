using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType.Models
{
    internal class Meet : Food
    {


        public Type Type;

        public Meet(int calorie, Type type) : base(calorie)
        {
            Type = type;
        }
    }
}
namespace GenericType
{
    public enum Type
    {
        Lamb,
        Beef,
        Chicken

    }
}
    

