using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_05
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
            for (int i2 = 0; i2 < array2.Length; i2++)
            {
              Console.WriteLine("Введите значения для массива 2:");
                array2[i2] = int.Parse(Console.ReadLine()); 
            }
            int[] array3 = new int[3];
            array3[0] = array[0] + array2[0];
            array3[1] = array[1] + array2[1];
            array3[2] = array[2] + array2[2];
            foreach (var sum in array3)
            {
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
