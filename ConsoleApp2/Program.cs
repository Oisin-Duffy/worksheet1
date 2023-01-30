namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part a");
            PrintIntegersFor();
            Console.WriteLine("\nPart b");
            PrintIntegersWhile();
            Console.WriteLine("\nPart c");
            PrintIntegersDo();
            Console.WriteLine("\nPart d");
            PrintExcludingFor();
            Console.WriteLine("\nPart e");
            PrintDescendingFor();
        }
        static void PrintIntegersFor() // part a
        {
            for (int i = 40; i <= 60; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintIntegersWhile() // part b
        {
            int i = 40;
            while (i <= 60)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void PrintIntegersDo() // part c
        {
            int i = 40;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 60);
        }
        static void PrintExcludingFor() // part d
        {
            for (int i = 40; i <= 60; i++)
            {
                if (i == 46 || i == 48)
                {

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void PrintDescendingFor()
        {
            for (int i = 60; i >= 40; i--)
            {
                Console.WriteLine(i);
            }
        }
    }