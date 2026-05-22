namespace Day3_Activity5_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number ? ");
            int num = int.Parse(Console.ReadLine());
            PrintMultiplicationTable(num);
        }
        public static void PrintMultiplicationTable(int number) {
            for (int i = 0; i <=12; i++)
            {
                Console.WriteLine($"{number} X {i} = {number*i}");
            }
        }
    }
}
