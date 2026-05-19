namespace Day3_Activity2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number ? ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i<=12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
            Console.ReadKey();
        }
    }
}
