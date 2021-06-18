using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._06
{
    class Program
    {
        static void Main(string[] args)
        {
            //ВАРИАНТ 10
            //1.Массив А вводится с клавиатуры. Сформировать новый массив В,
            //состоящий из положительных элементов массива А.
            //Размер произвольный.
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int[] b = new int[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i]>0)
                {
                    b[k] = a[i];
                    k = k + 1;
                }

            }
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadKey();

        }
    }
}
