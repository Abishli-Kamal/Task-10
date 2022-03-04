using System;

namespace task_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int m = 0;
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);

        }
    }
}

