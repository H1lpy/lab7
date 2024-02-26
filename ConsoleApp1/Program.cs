using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int[] q = new int[17];
            int[] p = new int[17];
            int n = -1;
            int pr = 1;
            int pr_p = 1;

            for (int i = 0; i < q.Length; i++)
            {
                q[i] = ran.Next(-10, 11);
                Console.Write($"{q[i]} ");
            }
            Console.WriteLine();

            for (int i = 0;i < q.Length; i++)
            {
                if (q[i] < 0)
                {
                    if(n == -1)
                    {
                        n = i;
                    }
                    pr *= q[i];
                }
            }
            Console.Write($"Произведение отрицательных элементов массива (q): {pr}. Номер первого встретившегося отриц. элемента: {n + 1}");
            Console.WriteLine();

            for (int i = 0; i < q.Length; i++)
            {
                p[i] = 2 * q[i] + 16;
                Console.Write($"{p[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < p.Length ; i+=2)
            {
                if (p[i] > 0)
                {
                    pr_p *= p[i];
                }
            }
            Console.Write($"Произведение положительных элементов массива (p), расположенных на нечетных позициях: {pr_p}");
            Console.WriteLine();
        }
    }
}
