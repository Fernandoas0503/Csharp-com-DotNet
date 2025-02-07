using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Exercicios_Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o primeiro valor: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo valor: ");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0)
            {
               Console.WriteLine("São Múltiplos!");
            }
            else
            {
                Console.WriteLine("Não são Multiplos!");
            }               

        }
    }
}