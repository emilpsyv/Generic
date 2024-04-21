using PlagiatTask.Models;

namespace PlagiatTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student emil = new("Emil", true, true);
            SabirTeacher.Parcalamag(emil);
        }
    }
}
