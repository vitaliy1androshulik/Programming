using System.Reflection.Metadata;

namespace HomeWorkPython
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int countOfQuestion = rnd.Next(1, 5);
            double c = countOfQuestion;
            int[] arr = new int[countOfQuestion];
            int firstNum;
            int secondNum;
            double mark = 12.0 / c;
            double finalMark = 0;
            int resUser;
            
            for (int i = 0; i < countOfQuestion; i++)
            {
                firstNum = rnd.Next(1, 20);
                secondNum = rnd.Next(1, 20);
                foreach (var item in arr)
                {
                    if (item == firstNum * secondNum)
                    {
                        firstNum = rnd.Next(1, 20);
                        secondNum = rnd.Next(1, 20);
                        Console.WriteLine($"Mark by question {Math.Round(mark, 2)}");
                        Console.Write($"{firstNum} * {secondNum} = ");
                        resUser = int.Parse(Console.ReadLine()!);
                        if (firstNum * secondNum == resUser)
                        {
                            Console.WriteLine("Good!!");
                            finalMark += mark;
                            arr[i] = firstNum * secondNum;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Bad!!. Try again!");
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine($"Mark by question {Math.Round(mark, 2)}");
                Console.Write($"{firstNum} * {secondNum} = ");
                resUser = int.Parse(Console.ReadLine()!);
                if (firstNum * secondNum == resUser)
                {
                    Console.WriteLine("Good!!");
                    finalMark += mark;
                    arr[i] = firstNum * secondNum;
                }
                else
                {
                    Console.WriteLine("Bad!!. Try again!");
                }
                Thread.Sleep(400);
            }
            Console.Clear();
            Console.WriteLine($"Good. Your mark {finalMark}");
        } 
            
    }
}
