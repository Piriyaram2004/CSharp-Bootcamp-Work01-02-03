namespace Day4_Activity9_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Validator.IsPasswordValid("wewfsgsvegasg"));
            Console.WriteLine(Validator.IsInRange(15, 4, 20)); 
            Console.WriteLine(Validator.IsPositive(34)); 
        }

    }
    public static class Validator
    {
        public static bool IsPositive(double number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsInRange(int number, int min, int max)
        {
            if (number >= min && number <=max)
            {
                return true;
            }
            return false;
        }
        public static bool IsPasswordValid(string password)
        {
            if (password.Length >= 8)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
