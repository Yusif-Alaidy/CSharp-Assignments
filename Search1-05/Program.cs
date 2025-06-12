using System.Xml;

namespace Search1_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new();
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\t╔==============================╗\n"+
                              "\t║   Enter Your Number Please   ║\n"+
                              "\t╚==============================╝\n");
                Console.Write("\t==>: ");
                int unique = Convert.ToInt32(Console.ReadLine());
                if (number.Contains(unique))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("This number already exist !");
                }
                number.Add(unique);
                
            } while (true);
        }
    }
}
