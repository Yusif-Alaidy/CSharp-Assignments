using System.Diagnostics.Tracing;

namespace Search2_05
{
    internal class Program
    {
        static bool isContainsVowels(string word)
        {
            char[] Vowels = { 'a', 'e', 'o','i','u'};
            for (int i=0;i<Vowels.Length;i++)
            {
                if (word.Contains(Vowels[i])) return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string Word = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\t╔============================╗\n" +
                              "\t║   Press Q for Quit         ║\n" +
                              "\t║   Enter Your Word Please   ║\n" +
                              "\t╚============================╝\n");
                Console.Write("\t==>: ");
                 Word = Console.ReadLine().ToLower();
                if (!isContainsVowels(Word))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("This Word does not contains vowels !");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t╔=======================╗\n" +
                              "\t║   Your Word is Good   ║\n" +
                              "\t╚=======================╝\n");


            } while (Word!="Q");
        }
    }
}
