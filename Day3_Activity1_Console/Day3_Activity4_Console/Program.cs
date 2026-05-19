namespace Day3_Activity4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  positive number N ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n ))
            {
                if (n > 0)
                {
                    int sum = 0;
                    for (int i = 0; i <= n; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"SUM IS {sum}");
                }
                else { Console.WriteLine("Enter positive number "); }
                
                {
                    
                }
            }
        }
    }
}
