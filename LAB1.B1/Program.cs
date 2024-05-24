using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1.B1
{
    public static class UserData
    {
        public static string ID;
        public static string UserName;
        public static float Health;
        public static int Point;

        // Constructor tĩnh để khởi tạo các giá trị
        static UserData()
        {
            ID = "2024";
            UserName = "Hide on bush";
            Health = 100.5f;
            Point = 100;
        }
        public static void DisplayUserData()
        {
            Console.WriteLine("ID: " + UserData.ID);
            Console.WriteLine("UserName: " + UserData.UserName);
            Console.WriteLine("Health: " + UserData.Health);
            Console.WriteLine("Point: " + UserData.Point);
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            UserData.DisplayUserData();
        }
    }
}
