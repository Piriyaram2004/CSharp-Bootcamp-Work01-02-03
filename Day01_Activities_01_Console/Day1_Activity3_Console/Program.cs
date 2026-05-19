namespace Day1_Activity3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Celsius");
            double temperature = double.Parse(Console.ReadLine());
            double Farenheite = (temperature * 9 / 5) + 32;
            Console.WriteLine($"Your temperatue in farenheite is {Farenheite}");
        }
    }
}
