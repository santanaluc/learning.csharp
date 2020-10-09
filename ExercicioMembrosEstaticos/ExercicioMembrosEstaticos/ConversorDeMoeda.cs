using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double Imposto = 0.06;
        public static double ValorTotal;

        public static double CalculoDolar(double valorComprar, double valorDolar)
        {
            return ValorTotal = (valorComprar * valorDolar);
        }

        public static double CalcularImposto()
        {
            return (ValorTotal * Imposto) + ValorTotal;
        }
    }
}
