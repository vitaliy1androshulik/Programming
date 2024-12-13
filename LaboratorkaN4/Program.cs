namespace LaboratorkaN4
{
    internal class Program
    {
        static void FirstFromFourth()
        {

            Console.Write("Enter your first number :: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Enter your second number :: ");
            double C = double.Parse(Console.ReadLine());
            Console.Write("Enter your third number :: ");
            double N = double.Parse(Console.ReadLine());

            double y = new double();
            if (A == C && C == N && A == N)
            {
                y = Math.Cos(A + C + N);
                Console.WriteLine($"A = C = N, your result = {y}");
            }
            else if (A < C && C == N)
            {
                y = Math.Cos(A * C * N);
                Console.WriteLine($"A < C = N, your result = {y}");
            }
            else if (A < C && C < N)
            {
                y = Math.Cos((A + C) * N);
                Console.WriteLine($"A < C < N, your result = {y}");
            }
            else
            {
                Console.WriteLine("Your result = 0");
            }
        }
        static void FirstFromFifth()
        {
            double x = new double();
            double y = new double();
            Console.Write("Enter your variant(1-3) :: ");
            int a = int.Parse(Console.ReadLine());
            double parY = new double();
            switch (a)
            {
                case 1:
                    {
                        x = 3.5;
                        y = 7.2;
                        parY = 2 - Math.Pow(x, 2);
                        if (y >= 0 && y <= parY)
                        {
                            Console.WriteLine("Yes, point A lies in the region");
                        }
                        else
                        {
                            Console.WriteLine("No, point A lies in the region");
                        }
                        break;
                    }
                case 2:
                    {
                        x = -0.5;
                        y = 1.2;
                        parY = 2 - Math.Pow(x, 2);
                        if (y >= 0 && y <= parY)
                        {
                            Console.WriteLine("Yes, point A lies in the region");
                        }
                        else
                        {
                            Console.WriteLine("No, point A lies in the region");
                        }
                        break;
                    }
                case 3:
                    {
                        x = 0.72;
                        y = -3.12;
                        parY = 2 - Math.Pow(x, 2);
                        if (y >= 0 && y <= parY)
                        {
                            Console.WriteLine("Yes, point A lies in the region");
                        }
                        else
                        {
                            Console.WriteLine("No, point A lies in the region");
                        }
                        break;
                    }
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            FirstFromFourth();
            Console.ReadLine();
            FirstFromFifth();
            Console.ReadLine();
        }
    }
}
