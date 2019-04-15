using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_05_1_fixed
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine("Введите элементы массива");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine($"array{i}={array[i]}");
            }
            int cell = 10;
            while (cell < 0 | cell > array.Length - 1)
            {
                Console.WriteLine("Введите ячейку");
                cell = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите поcледний элемент массива");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i == cell - 1)
                {
                    array[i] = num;
                    break;
                }
                array[i] = array[i - 1];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}]={array[i]}");
            }
            Console.ReadKey();
        }
    }
}
