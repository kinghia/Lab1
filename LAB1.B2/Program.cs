using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1.B2
{
    class Maps
    {
        private static string _inGame = "Liên minh huyền thoại";

        public int ID { get; set; }
        public string Name { get; set; }
        public Maps(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public Maps()
        {
        }

        public string ShowData()
        {
            return "ID: " + ID + " | Name: " + Name + " | inGame: " + _inGame;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var maps1 = new Maps(2024, "URF");
            Console.WriteLine(maps1.ShowData());

            var maps2 = new Maps()
            {
                ID = 2024,
                Name = "URF"
            };
            Console.WriteLine(maps2.ShowData());
        }
    }
}
