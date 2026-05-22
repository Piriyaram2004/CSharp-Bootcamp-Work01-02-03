namespace Day4_Activity8_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greet();
            Greet("GOKU");
            Greet("Vegeta",5);
        }
        public static void Greet()
        {
            Console.WriteLine("Hello,Guest!");
        }
        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
        public static void Greet(string name, int times)
        {
            for (int i = 0; i <=5 ; i++)
            {
                Console.WriteLine($"Hello,{name}");
            }
        }

    }
}
