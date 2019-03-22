using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW._6
{
    class Program
    {
        static void Main(string[] args)
        {
            void task_1()
            {
                int[] arr = new int[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr.Length);
                }
            }
            void task_2()
            {
                var array = new object[]
                {
                  32,
                 'A',
                 "Hello"
                 };
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"array[{i}] = {array[i]}");
                }
                array[0] = Convert.ToInt32(array[0]) + 10;
                array[2] = array[2] + ",guys";
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"array[{i}] = {array[i]}");
                }

            }
            void task_3()
            {
                int[] array3 = new int[13];
                Random rand = new Random();
                for (int i = 0; i < array3.Length; i++)
                {
                    array3[i] = rand.Next();
                    Console.WriteLine($"array[{i}] = {array3[i]}");
                }
                int max = array3.Max();
                Console.WriteLine($"Максимально значение {max}");
            }
            task_1();
            task_2();
            task_3();
            Console.ReadKey();
           
        }
    }
}
