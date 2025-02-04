using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int Qtd_Num = int.Parse(Console.ReadLine());

            int Soma = 0;

            for (int i = 1; i <= Qtd_Num ; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int Valor = int.Parse(Console.ReadLine());

                Soma = Soma + Valor;                
            }

            Console.Write("A soma é: " + Soma);

        }
    }
}