using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            string str1 = Console.ReadLine();
            string[] arr = str1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var sell = 0;
            var maxLength = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > maxLength)
                {
                    maxLength = arr[i].Length;
                    sell = i;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[sell] = default(string);
            }
            arr = arr.Where(x => x != null).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();

            //Task 2

            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string[] arr1 = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var sell1 = 0;
            var sellMin1 = 0;
            var maxLength1 = 0;
            var minLenght1 = 9999;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i].Length > maxLength1)
                {
                    maxLength1 = arr1[i].Length;
                    sell1 = i;
                }
                else if (arr1[i].Length < minLenght1)
                {
                    minLenght1 = arr[i].Length;
                    sellMin1 = i;
                }
            }
            //Task 3
            string inter = arr[sell];
            arr[sell] = arr[sellMin];
            arr[sellMin] = inter;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();

            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            int ind = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i, 1) != " ")
                    ind++;
            }
            Console.WriteLine("Количество букв равно {0}", ind);
            Console.ReadKey();


        }
    }
}
