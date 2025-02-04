<<<<<<< HEAD
using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.Write("Entre com o código do produto: ");
            int cod_prod = int.Parse(Console.ReadLine());

            while (cod_prod != 4)
            {
                if (cod_prod == 1)
                {
                    alcool = alcool + 1;
                }
                else if (cod_prod == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (cod_prod == 3)
                {
                    diesel = diesel + 1;
                }

                cod_prod = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
=======
using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.Write("Entre com o código do produto: ");
            int cod_prod = int.Parse(Console.ReadLine());

            while (cod_prod != 4)
            {
                if (cod_prod == 1)
                {
                    alcool = alcool + 1;
                }
                else if (cod_prod == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (cod_prod == 3)
                {
                    diesel = diesel + 1;
                }

                cod_prod = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
>>>>>>> bac9da869a4e24ff3463511001dda75604d17b45
}