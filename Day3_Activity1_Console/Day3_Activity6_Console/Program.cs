namespace Day3_Activity6_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=1000; i++)
            {
                if (i % num == 0)
                {
                    Console.WriteLine($"YOU CHOOSE FIRST MULTIPLE OF {num} IS {i}!!!");
                    break;
                }
            }
            Console.WriteLine("LOOP ENDED !");
        }
    }
}
