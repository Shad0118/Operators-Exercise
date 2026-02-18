namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise - 1
            int a = 17;
            int b = 4;
            Console.WriteLine($"Sum : {Addition(a, b)}\nDifference : {Subtraction(a,b)}\nMultiplication : {Multiplication(a, b)}\nQuotient : {Division(a, b)}   Reminder : {Reminder(a, b)}");
            //Exercise - 2
            Console.WriteLine("Please enter the radius to calculate area of a circle.");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the circle is : {AreaOfCircle(radius)}");
        }
        //Exercise 1 Methods.
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }

        public static double Reminder(double a, double b)
        {
            return a % b;
        }
        //Exercise 2 Methods.
        public static double AreaOfCircle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            //double area = Math.PI * r * r;
            return area;
        }
    }
}
