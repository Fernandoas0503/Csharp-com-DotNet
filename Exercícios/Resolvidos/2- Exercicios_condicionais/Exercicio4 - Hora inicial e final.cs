using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Exercicios_Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a hora inicial: ");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a hora final: ");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;
            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}