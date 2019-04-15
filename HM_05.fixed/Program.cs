using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_05fixed
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            int[] array2 = new int[3];
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Введите значения для массива 2:");
                array2[i] = int.Parse(Console.ReadLine());
            }
            int[] array3 = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i] + array2[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }

            Console.ReadKey();
        }
    }
}
