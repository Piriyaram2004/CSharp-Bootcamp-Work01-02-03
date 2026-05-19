namespace Day1_Activity5_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ENTER THE WIDTH IN CM");
            int WIDTH = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE HEIGHT IN CM ");
            int HEIGHT = int.Parse(Console.ReadLine());
            int AREA = HEIGHT * WIDTH;
            Console.WriteLine("ENTER THE RADIUS OF A CIRCLE IN CM ");
            double RADIUS = double.Parse(Console.ReadLine());
            double CIRCLEAREA = (Math.PI * RADIUS * RADIUS);
            Console.WriteLine($"AREA OF A RECTANGLE IS {AREA} CM");
            Console.WriteLine($"AREA OF A CIRECLE IS {CIRCLEAREA} CM");

        }
    }
}
