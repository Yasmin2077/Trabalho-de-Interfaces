using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_Interfaces
{
    public class CalculadoraHyper : ICalculadora<double>
    {

        public double Adicao(double numA, double numB)
        {
            return numA + numB;
        }
        public double Subtracao(double numA, double numB)
        {
            return numA - numB;
        }
        public double Multiplicacao(double numA, double numB)
        {
            return numA * numB;
        }
        public double Divisao(double numA, double numB)
        {
            if (numB == 0)
            {
                throw new ArgumentException("não tem como dividir");


            }
            return numA / numB;
        }
    }

}
