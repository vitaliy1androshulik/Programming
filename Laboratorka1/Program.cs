namespace Laboratorka1
{
    internal class Program
    {
        static double First()
        {
            double x = new double();
            double c = new double();
            double a = new double();
            double L = new double();

            Console.Write("Enter first number (a) :: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number (x) :: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter third number (c) :: ");
            c = double.Parse(Console.ReadLine());

            L = (Math.Sqrt(Math.Exp(x) - Math.Pow(Math.Cos(x * x * Math.Pow(a, 5)), 4))
                + (Math.Pow(Math.Atan(a - Math.Pow(x, 5)), 4))
                / (Math.E * Math.Sqrt(Math.Abs(a + (x * Math.Pow(c, 4))))));
            return L;
        }
        static void Second()
        {
            const double b = 0.4;
            double x = new double();
            double a = new double();
            double t = new double();
            Console.Write("Enter your X (3.5) :: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter your A :: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter your T :: ");
            t = double.Parse(Console.ReadLine());

            double Y = Math.Exp(2 * x) + Math.Pow(9.7, t);
            double C = Math.Pow(a, 2) + Math.Sqrt(b * x);
            double A = Math.Log(x);
            Console.WriteLine($"Your Y :: {Y}");
            Console.WriteLine($"Your C :: {C}");
            Console.WriteLine($"Your A :: {A}");

        }

        static void Third()
        {
            bool A = true;
            bool B = false;
            bool X = false;

            bool resA = (A || !A && B) || X;
            Console.WriteLine($"First result :: {resA}" );
            bool resB = !A || (A && (B || X));
            Console.WriteLine($"Second result :: {resB}");
            bool resC = (A || (B && !X)) && X;
            Console.WriteLine($"Third result :: {resC}" );
        }
        static void Main(string[] args)
        {
            double res1 = First();
            Console.WriteLine($"Your first result = {res1}");
            Console.ReadLine();
            Console.Clear();
            Second();
            Console.ReadLine();
            Console.Clear();
            Third();
        }
    }
}