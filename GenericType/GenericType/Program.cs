using GenericType.Models;

namespace GenericType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf wolf = new Wolf(12, "sibirian", 150,Gender.male, true, 12);
            Elephant elephant = new Elephant(30, "afrika", 1200, Gender.male, 2000, true);
            Console.WriteLine(elephant.HP);
            wolf.Hunt<Elephant>(elephant);
            
            elephant.Feed();
            elephant.Feed();
          



            Meet meet = new Meet(1400, Type.Beef);

            ZooCage<Wolf,Meet> zooCage = new ZooCage<Wolf, Meet>(wolf,meet); 

        }
    }
}
