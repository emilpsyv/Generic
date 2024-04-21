using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagiatTask.Models
{
    internal class Student
    {
       public string Name;
       public bool IsHelpedToPlagiat;
       public bool IsPlagiat;
        public Student(string name,bool isplagiat,bool ishelped)
        {
            Name = name;
            IsPlagiat = isplagiat;
            IsHelpedToPlagiat = ishelped;
            
        }
    }
}
