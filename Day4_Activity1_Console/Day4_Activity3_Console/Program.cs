namespace Day4_Activity3_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           static int Add(int a, int b) {
                return a + b;
            }
            static  int Subtract(int a, int b) {
                return a - b;
            }

static  int  Multiply(int a, int b) {
                return a * b;
            }
            static  double Divide(double a, double b)
            {
                return a / b;
            }
            Console.WriteLine("Add"+" "+Add(1,3));
            Console.WriteLine("Subtract " + " " + Subtract(10,3));
            Console.WriteLine("Multiply" + " " + Multiply(1,3));
            Console.WriteLine("Divide" + " " + Divide(21,3));

        }
    }
}
