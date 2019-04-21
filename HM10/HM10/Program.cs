using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM10
{
    class Program
    {
        static void Main(string[] args)
        {          
            Square square = new Square();
            square.name = "Sqare";            
            Cricle cricle = new Cricle();
            cricle.name = "Cricle";
            Triangle triangle = new Triangle();
            triangle.name = "Triangle";
            IBase[] bases = new IBase[]
            {
                cricle,
                triangle,
                square
            };
            for (int i = 0; i < bases.Length; i++)
            {
                Console.WriteLine($"This is {bases[i].name}.CLR Type is {bases[i].GetType()}.Sqare is {bases[i].Ar()} ");
            }
            Console.ReadKey();
        }
    }
}
