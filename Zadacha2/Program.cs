using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба");
            int a = Convert.ToInt32(Console.ReadLine());
            CubeSize(a, out double S, out double V);
            Console.ReadKey();
        }
        static void CubeSize(int a, out double S, out double V)
        {
            S = a * a * 6;
            V = a * a * a;
            Console.WriteLine("Площадь поверхности куба с ребром {0} равна {1}",a, S);
            Console.WriteLine("Обьем куба с ребром {0} равен {1}", a, V);
        }

        
    }
}
