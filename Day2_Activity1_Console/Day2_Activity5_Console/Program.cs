namespace Day2_Activity5_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basePrice = 12.50;
           
          
            Console.WriteLine("Enter your age ? ");
            int age = int.Parse(Console.ReadLine());
            if (age <= 12 || age >= 65)
            {
                basePrice = basePrice - (basePrice * 0.5);
                Console.WriteLine($"Discount price is {basePrice}");
            }
            Console.WriteLine("Are you a student Yes / No ?");
            string isstudent = (Console.ReadLine().ToLower());
            if (isstudent=="yes")
            {
                basePrice = basePrice - (basePrice * 0.25);
                Console.WriteLine($"Discounted price for student is  {basePrice}");
            }
            Console.ReadKey();
        }
    }
}
