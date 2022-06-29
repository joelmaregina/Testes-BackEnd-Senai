using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriVitta
{
    public static class CauculadoraIMC
    {
        public static double Imc(double peso, double altura)
        {
            return (peso / (altura * altura));
        }

        public static string ClassificacaoIMC(double imc)
        {
            var Classe = "";

            if (imc < 18.5)
            {
                Classe = "Abaixo do peso";
            }
            else if (imc <= 24.9)
            {
                Classe = "Peso normal";
            }
            else if (imc <= 29.9)
            {
                Classe = "Sobrepeso";
            }
            else if (imc <= 34.9)
            {
                Classe = "Obesidade grau I";
            }
            else if (imc <= 39.9)
            {
                Classe = "Obesidade grau II";
            }
            else if (imc >= 40)
            {
                Classe = "Obesidade grau III";
            }

            return Classe;
        }
    }
}
