namespace Day1_Activity4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num1");
            int num2 = int.Parse(Console.ReadLine());
            int SUM = num1 + num2;
            int DIFFERNECE  = num1 - num2;
            int PRODUCT = num1 * num2;
            double QUOTIENT = num1 / num2;
            Console.WriteLine($"SUM IS {SUM}");
            Console.WriteLine($"DIFFERNECE IS {DIFFERNECE}");
            Console.WriteLine($"PRODUCT IS {PRODUCT}");
            Console.WriteLine($"QUOTIENT IS {QUOTIENT}");

        }
    }
}
