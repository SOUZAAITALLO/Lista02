using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado area1;
            area1 = new Quadrado();

            Console.WriteLine("\n---------Exercício 2 da Lista 1---------\n");

            Console.Write("Insira o Valor da Areasta do Quadrado(m): ");
            area1.setAresta(double.Parse(Console.ReadLine()));


            area1.calcular();

            Console.WriteLine("");

            Console.WriteLine("A Área do Quadrado de Aresta {0}m é {1}m²",
                area1.getAresta(), area1.getArea());
        }
    }
}
