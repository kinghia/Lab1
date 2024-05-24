using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.B3
{
    internal partial class Numbers
    {
        public int Cong()
        {
            return a + b;
        }

        public int Tru()
        {
            return a - b;
        }

        public int Nhan()
        {
            return a * b;
        }

        public double Chia()
        {
            return (double)a / b;
            if (b == 0)
            {
                Console.WriteLine("Sai: Không thể chia cho số không");
                return double.NaN;
            }
        }
    }
}
