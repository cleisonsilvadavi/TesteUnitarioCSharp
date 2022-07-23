using System;
using Calculadora.Services;


namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraImp c = new CalculadoraImp();
            int num1 = 10;
            int num2 = 5;
   
            Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");
        }
    }
}
