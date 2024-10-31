using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            Console.Write("Escreva o valor da altura: ");
            area.setaltura(int.Parse(Console.ReadLine()));
            Console.Write("Escreva o valor da base: ");
            area.setBase(int.Parse(Console.ReadLine()));
            area.AreaRet();
            Console.WriteLine("O valor da area é de: {0}",area.getArea());
        }
    }
}
