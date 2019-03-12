using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1c
            Console.WriteLine("Число 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int res = num1 + num2;
            Console.WriteLine($"Результат: {res}");


            // Task 2
            Console.WriteLine("Число 1:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число 2:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат сложения?");
            int num5 = Convert.ToInt32(Console.ReadLine());

            int num6 = num3 + num4;
            bool c = num5 == num6;

            Console.WriteLine(c);



            //Task 3
            Console.WriteLine("Число 1:");
            int num8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число 2:");
            int num9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат cложения?");
            int num10 = Convert.ToInt32(Console.ReadLine());
            int num11 = num8 + num9;
            bool c1 = num10 == num11;
            string t;
            Console.WriteLine(c1);
            t = (num10 < num11) ? "Должно быть больше " : "Должно быть меньше";
            Console.WriteLine(t);


            //Task 4

            Console.WriteLine("Число 1:");
            int num12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число 2:");
            int num13 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите + или -");

            string t4 = Console.ReadLine();
            int z = t4 == "+" ? (num12 + num13) : (num12 - num13);
            Console.WriteLine("Результат ?");
            int num14 = Convert.ToInt32(Console.ReadLine());
            bool c2 = num14 == z;
            Console.WriteLine(c2);
            string t2;
            t2 = (num14 < z) ? "Должно быть больше " : "Должно быть меньше";
            Console.WriteLine(t2);





        }
    }
}
