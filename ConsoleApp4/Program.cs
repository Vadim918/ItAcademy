using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[0];
            foreach (var item in array)
            {
                Console.WriteLine(array.Length);
            }
            Console.ReadKey();
            //Task 2
            int[] array1 = new int[3];
            array1[0] = 32;
            array1[1] = 'a' ;
            array1[2].ToString();
            array1[2] = "Hello";
            int sum = array1[0] = 10;
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);

            }
            Console.ReadKey();


        }
    }
}
