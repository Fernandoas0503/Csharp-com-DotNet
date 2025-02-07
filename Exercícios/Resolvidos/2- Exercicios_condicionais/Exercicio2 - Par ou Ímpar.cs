using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Exercicios_Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor: ");
            int X = int.Parse(Console.ReadLine());

            
            if (X % 2 == 0)
            { 
               Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }
        }
    }
}