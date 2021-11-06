using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну стороны первого треугольника х1=");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длинну стороны первого треугольника y1=");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длинну стороны первого треугольника z1=");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длинну стороны второго треугольника х2=");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длинну стороны второго треугольника y2=");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длинну стороны второго треугольника z2=");
            int z2 = Convert.ToInt32(Console.ReadLine());
            double S1 = AreaTriangle(x1, y1, z1);
            double S2 = AreaTriangle(x2, y2, z2);
            if (S1 > S2)
                Console.WriteLine("Площадь первого треугольника = {0:f2}, больше площади второго = {1:f2}", S1, S2);
            if (S1 < S2)
                Console.WriteLine("Площадь второго треугольника = {1:f2}, больше площади первого = {0:f2}", S1, S2);
            if (S1 == S2)
                Console.WriteLine("Площадь первого треугольника = {0:f2}, ровна площади второго = {1:f2}", S1, S2);
            Console.ReadKey();
        }
        static double AreaTriangle(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            if (p <= a || p <= b || p <= c)
                Console.WriteLine("Длинн сторон не образуют треугольник {0},{1},{2}", a, b, c);
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;

        }
    }
}
