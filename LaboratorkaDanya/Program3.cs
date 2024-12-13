namespace LaboratorkaDanya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,10);  
            }
            Console.WriteLine("Your array:");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            int a = 5;
            int b = 10; 

            int[] result = CompressArray(array, a, b);

            Console.WriteLine("\nCompress array:");
            foreach (int item in result)
            {
                Console.Write(item + " ");
            }

            static int[] CompressArray(int[] array, int a, int b)
            {
                int[] compArr = new int[array.Length];
                int index = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < a || array[i] > b)
                    {
                        compArr[index++] = array[i];
                    }
                }

                for (int i = index; i < compArr.Length; i++)
                {
                    compArr[i] = 0;
                }

                return compArr;
            }
        }
    }
}
