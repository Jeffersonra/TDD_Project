using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            Console.Write(" Iniciando Processamento: \n");
            Console.Write("--------------------------\n");
            Console.Write("\nDigite N1: ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("\nDigite N2: ");
            n2 = Convert.ToInt16(Console.ReadLine());
            Calculos calcula = new Calculos();
            var result = calcula.Somar(n1,n2);
            Console.Write("\nResultado: " + result);
            Console.ReadKey();
        }
    }
}
