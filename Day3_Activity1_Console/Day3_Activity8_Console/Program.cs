namespace Day3_Activity8_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int rows = 5;
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*"); 
                    }
                    Console.WriteLine();
                }
            }
        }
    }
