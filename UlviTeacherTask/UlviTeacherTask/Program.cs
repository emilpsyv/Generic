using System.Threading.Channels;
using UlviTeacherTask.Models;

namespace UlviTeacherTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new("AB106");
            Group ab105 = new("AB105");

            List<Student> students = new();
            students.Add(new Student("Emil", "Akula", 20, 200, ab106));
            students.Add(new Student("Samir", "Kerimov", 20, 700, ab106));
            students.Add(new Student("Ali", "Shukurov", 19, 400, ab105));
            students.Add(new Student("Nurlan", "Abbasov", 19, 600, ab105));
            students.Add(new Student("Garib", "Garibzade", 15, 160, ab106));


            Console.WriteLine("ab106 qurundakiler: ");
            students.FindAll(s => s.Group == ab106).ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Surname));

            Console.WriteLine("\n300den asagi bali olanlar: ");
            students.FindAll(s => s.Credits < 300).ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Surname));

            Console.WriteLine("\nEnenevi foreach yazmadan butun telebelerin Ad soyadini yan yana yazin.");
            students.FindAll(s => s == s).ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Surname));

            Console.WriteLine("\nAdinda b herfi olan telebeleri cixarin.");
            students.FindAll(s => s.Name.ToLower().Contains("b")).ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Surname));

            Console.WriteLine("\nTelebeleri kredit sayina gore siralayin (Hazir methodu var).");
            students.OrderBy(s => s.Credits).ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Credits));

            Console.WriteLine("\nUmumi kreditlerin cemini tapin.");
            Console.WriteLine(students.Sum(s => s.Credits));

            Console.WriteLine("\n18 yasindan asagi telebe varmi?");
            Console.WriteLine(students.Any(s => s.Age < 18));

            Console.WriteLine("\nButun telebeler en az 200 kredit odeyibmi?");
            Console.WriteLine(students.Any(s => s.Credits > 199));

            Console.WriteLine("\nKredit sayi cox olan en kicik telebeni tapin.");
            var stdWithHighCredits = students.OfType<Student>().Where(s => s.Credits > 0);
            var smallestAgeStd = stdWithHighCredits.OrderBy(s => s.Age).FirstOrDefault();
            Console.WriteLine(smallestAgeStd.Name + " " + smallestAgeStd.Surname);


            Console.WriteLine("\nQruplara gore siralayin");
            var groupedStudents = students.GroupBy(student => student.Group);


            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Group {group.Key.Name}:");
                foreach (var student in group)
                {
                    Console.WriteLine($"{student.Name} {student.Surname} {student.Age} {student.Credits}");
                }
            }
        }
    }
}
