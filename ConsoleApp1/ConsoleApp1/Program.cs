using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number1 : ");
            int Number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number2 : ");
            int Number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number3 : ");
            int Number3 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number4 : ");
            int Number4 = int.Parse(Console.ReadLine());
            int max = Number1;
            int min = Number1;
            if (max < Number2) max = Number2;
            if (max < Number3) max = Number3;
            if (max < Number4) max = Number4;
            if (min > Number2) min = Number2;
            if (min > Number3) min = Number3;
            if (min > Number4) min = Number4;
            Console.WriteLine($"Max : {max}");
            Console.WriteLine($"Min : {min}");
            Console.WriteLine($"Result : {max - min }");
            Main(args);           
        }
    }
}
