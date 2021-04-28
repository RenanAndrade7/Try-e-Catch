using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo!!");
            Console.WriteLine("Digite dois numeros para serem feitos a divisão: ");

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine("O Resultado é : " + result.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Não é permitido a divisão por 0");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Formato errado!!" + e.Message);
            }

            finally
            {
                Console.WriteLine("O Código Finally executa uma operação no final de Try e Catch");
            }
        }
    }
}
