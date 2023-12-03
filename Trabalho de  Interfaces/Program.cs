// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using Trabalho_de_Interfaces;

namespace Trabalho_de_Interfaces
{


    class Program
    {
        static void Main()
        {
            CalculadoraHyper hyper = new CalculadoraHyper();
            Console.WriteLine(hyper);
            double resultAdicao = hyper.Adicao(7.0, 3.0);
            double resultSubtracao = hyper.Subtracao(5.0, 2.0);
            double resultMultiplicacao = hyper.Multiplicacao(4.0, 9.5);
            double resultadDivisao = hyper.Divisao(10.0, 7);
            Console.WriteLine(resultAdicao);
            Console.WriteLine(resultSubtracao);
            Console.WriteLine(resultMultiplicacao);
            Console.WriteLine(resultAdicao);
        }
    }
}        