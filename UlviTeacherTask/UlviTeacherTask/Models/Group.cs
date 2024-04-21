using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlviTeacherTask.Models
{
    internal class Group
    {
        static int _count = 1;
        public int Id { get; }
        public string Name { get; set; }
        public Group(string name)
        {
            Id = _count++;
            Name = name;
        }
    }
}
