using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.shapes;

namespace demo.ConsoleApp
{
    class Program
    {
        private static int num = 10;

        public static int GetNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            Shape s = new Shape(1, 2);
            Shape s2 = new Shape(3, 5);
            Rec r = new Rec(3, 6);
            Tri t = new Tri(2, 5);

            List<Shape> sh = new List<Shape>();
            List<int> numbs = new List<int>();
            sh.Add(s);
            sh.Add(s2);
            //numbs.Add(s.Area());
            sh.FindAll(o => o.Area() > 4);
           
            Console.WriteLine(s.Area());
            Console.WriteLine(r.Area());
            Console.WriteLine(t.Area());
            Console.ReadLine();
        }
    }
}
