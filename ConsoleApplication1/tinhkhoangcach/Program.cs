using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhkhoangcach
{
    class Program
    {
        static void Main(string[] args)
        {
            double d;
            int x;
            int y;
            int u;
            int v;
            Console.WriteLine("nhap vao toa do diem 1");
            Console.Write("\n nhap vao x1 = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("\n nhap vao y1 = ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao toa do diem 2");
            Console.Write("\n nhap vao x2 = ");
            u = int.Parse(Console.ReadLine());
            Console.Write("\n nhap vao y2 = ");
            v = int.Parse(Console.ReadLine());
            d = Math.Sqrt((x - u) * (x - u) + (y - v) * (y - v));
            Console.Write("\nd = {0}", d);
            Console.ReadKey();
        }
    }
}
