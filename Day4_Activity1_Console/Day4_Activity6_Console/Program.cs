namespace Day4_Activity6_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.FahrenheitToCelsius(212));
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(100));
        }

    }
    public static class TempConverter {

     public static double CelsiusToFahrenheit(double celsius) {
            double f = (celsius * 9 / 5) + 32;
            return f;
        }
     public static double FahrenheitToCelsius(double fahrenheit) {
            double c = (fahrenheit - 32) * 5 / 9;
            return c;
               
        }
    }
}
