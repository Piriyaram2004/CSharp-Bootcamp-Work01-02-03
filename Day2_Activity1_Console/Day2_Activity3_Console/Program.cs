namespace Day2_Activity3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in kilograms ? ");
            double weight = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter your height in meters ? ");
            double height = double.Parse(Console.ReadLine());
            double BMI = weight / (height * height);
            if (BMI <= 18.5)
            {
                Console.WriteLine("Underweight");

            }
            else if (BMI <= 24.9)
            {
                Console.WriteLine("Normal Weight");
            }
            else if (BMI <= 29.9)
            {
                Console.WriteLine("Over Weight");
            }
            else {
                Console.WriteLine("Obesity");
            }
        }
    }
}
