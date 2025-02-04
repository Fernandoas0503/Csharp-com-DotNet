using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a primeira coordenada : ", CultureInfo.InvariantCulture);
            int x = int.Parse(Console.ReadLine());

            Console.Write("Entre com a segunda coordenada : ", CultureInfo.InvariantCulture);
            int y = int.Parse(Console.ReadLine());


            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("NULO");
            }
        }
    }
}