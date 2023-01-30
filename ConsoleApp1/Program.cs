namespace Worksheet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersFor();
        }
        static void PrintIntegersFor()
        {

            for (int i = 40; i <= 60; i++)
            {
                i++;

                Console.WriteLine();

                Console.WriteLine(i);

            }

        }
    }
}