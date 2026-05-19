namespace Day3_Activity3_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "csharp";
            string guess = "";
            while (guess != word)
            {
            Console.WriteLine("guess the word");
                guess = Console.ReadLine().ToLower();

            }
            Console.WriteLine("CONGRATS  !!! ");
            Console.ReadKey();
        }
    }
}
