using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milha mi = new Milha();
            Console.Write("Escreva o valor da milha maritima que deseja converter: ");
            mi.setmilha(double.Parse(Console.ReadLine()));
            mi.converter();
            Console.WriteLine("O valor da converão é de: {0} Km",mi.getresultado());
        }
    }
}
