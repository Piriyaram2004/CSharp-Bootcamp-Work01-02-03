namespace Day4_Activity2_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ?  ");
        string name = Console.ReadLine();
            static void GreetUser(string name) {
                Console.WriteLine($"Hello, {name}!");
            }
            GreetUser(name);

        }
    }
}
