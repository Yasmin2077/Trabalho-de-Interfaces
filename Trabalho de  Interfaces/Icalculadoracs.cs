using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_Interfaces
{
     interface  ICalculadora<T>
     {
        double Adicao(T numA, T numB);
        double Subtracao (T numA, T numB);
        double Multiplicacao(T numA, T numB);
        double Divisao (T numA, T numB);
     }
}
