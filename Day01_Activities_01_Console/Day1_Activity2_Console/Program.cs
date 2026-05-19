namespace Day1_Activity2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your FirstName?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your LastName?");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter your Favourite Color?");
            string FavouriteColor = Console.ReadLine();
            Console.WriteLine($"User Bio : {FirstName} {LastName} Favourite color is {FavouriteColor}");
        }
    }
}
