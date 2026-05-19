namespace Day3_Activity7_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=50; i++)
            {
                if (i % 2 ==0)
                {
                    continue;
                }
                Console.WriteLine($"Odd number : {i}");
            }
            Console.ReadKey();
        }
    }
}
