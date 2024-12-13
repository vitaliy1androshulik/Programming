namespace HomeWorkInPaper
{
    internal class Program
    {
        static void Calculations()
        {
            Console.Write("Enter number count :: ");
            int n = int.Parse(Console.ReadLine());

            int posEvenCount = 0;
            int negEvenCount = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1} :: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 0)
                {
                    posEvenCount++;
                }
                if (num < 0 && num % 2 == 0)
                {
                    negEvenCount++;
                }
                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"Count of positive even numbers :: {posEvenCount}");
            Console.WriteLine($"Count of negative even numbers :: {negEvenCount}");
            Console.WriteLine($"Max. number :: {max}");
            Console.WriteLine($"Min. number :: {min}");
        }
        static void Main(string[] args)
        {
            Calculations(); 
        }
    }
}
