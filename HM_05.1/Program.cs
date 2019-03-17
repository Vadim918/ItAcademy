using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_05._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine("Введите элементы массива");
                array[i] = int.Parse(Console.ReadLine());   
            }
            for (int i2 = 0; i2 < array.Length - 1; i2++)
            {
                Console.WriteLine($"Массив:{array[i2]}");
            }
            Console.WriteLine("Введите полседний элемент массива");
            array[2] = int.Parse(Console.ReadLine());
            for (int i3 = 0; i3 < array.Length; i3++)
            {
               Console.WriteLine($"Массив:{array[i3]}");
            }
            Console.ReadKey();
        }
    }
}
