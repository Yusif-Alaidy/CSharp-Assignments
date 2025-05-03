namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable
            int smallCarept;
            int largCarept;
            int cost;
            double tax;
            // endVariable
            Console.WriteLine("Hello, At Islam Washer");

            Console.WriteLine("\nthe small carept cleaning costs 25 pounds");
            Console.WriteLine("How many small carpt would you like to wash ?");
            smallCarept = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nthe large carept cleaning costs 35 pounds");
            Console.WriteLine("How many larg carpt would you like to wash ?");
            largCarept = Convert.ToInt32(Console.ReadLine());

            cost = (smallCarept * 25) + (largCarept * 35);
            tax = 6.0;

            // output
            Console.WriteLine($"\nTotal estimate: {cost + ((tax / 100) * cost)}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
