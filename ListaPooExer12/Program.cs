using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hipotenusa hp = new Hipotenusa();
            Console.Write("Escreva o primeiro valor: ");
            hp.setvl1(double.Parse(Console.ReadLine()));
            Console.Write("Escreva o segundo valor: ");
            hp.setvl2(double.Parse(Console.ReadLine()));
            Console.Write("Escreva o terçeiro valor: ");
            hp.setvl3(double.Parse(Console.ReadLine()));
            hp.TrianguloRet();

        }
    }
}
