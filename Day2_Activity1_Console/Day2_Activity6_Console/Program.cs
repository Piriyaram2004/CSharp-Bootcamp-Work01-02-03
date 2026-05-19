namespace Day2_Activity6_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = false;
            while (!running)
            {
                
                Console.WriteLine("Enter the year ? ");
                int year = int.Parse(Console.ReadLine());
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("It is a leap year.");
                }
                else
                {
                    Console.WriteLine("It is not a leap year");
                }
                Console.WriteLine("Enter 'Exit' to exit from the loop ? ");
                String key = Console.ReadLine().ToLower();
                if (key == "exit")
                {
                    Console.WriteLine("Thankyou for Exiting !!! ");
                    break;
                }

            }
            running = true;
           
            Console.ReadKey();
        }
    }
}
