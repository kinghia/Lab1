using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers nb = new Numbers();
            nb.a = 50;
            nb.b = 10;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"a = {nb.a}, b = {nb.b}");
            Console.WriteLine($"Tổng: {nb.Cong()}");
            Console.WriteLine($"Thương: {nb.Tru()}");
            Console.WriteLine($"Tích: {nb.Nhan()}");
            Console.WriteLine($"Thương: {nb.Chia()}");
            Console.ReadLine();
        }
    }
}
