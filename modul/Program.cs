namespace modul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            double[] A = new double[n];

            for (int i = 1; i <= n; i++)
            {
                double sum = 0.0;

                for (int j = 1; j <= i; j++)
                {
                    sum += 1.0 / j;
                }

                double fact = 1.0;
                for (int k = 1; k <= i; k++)
                {
                    fact *= k;
                }
                A[i - 1] = sum / fact;
            }
            Console.WriteLine("Your Array :: ");
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }

            double product = 1.0;
            for (int i = 1; i < n; i += 2)
            {
                product *= A[i];
            }
            Console.WriteLine("Product of elements with even indices: " + product);
        }
    }
}
