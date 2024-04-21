using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagiatTask.Models
{
    internal class SabirTeacher
    {
        Student student;
        public static void Parcalamag(Student student)
        {
            Console.WriteLine( "Sabir teacher "+student.Name+"'li mefh eledi");
        }
    }
}
