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
            Console.Write("Entre com a senha: ");
            int senha = int.Parse(Console.ReadLine());
            
            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                Console.Write("Tente novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
            
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
            Console.Write("Entre com a senha: ");
            int senha = int.Parse(Console.ReadLine());
            
            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                Console.Write("Tente novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
            
        }
    }
>>>>>>> bac9da869a4e24ff3463511001dda75604d17b45
}