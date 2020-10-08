using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double NotaFinal;

        public double CalcularNota()
        {
            return NotaFinal = (Nota1 + Nota2 + Nota3);
        }

        public bool Aprovado()
        {
            if (NotaFinal >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SituacaoFinal()
        {
            if (Aprovado())
            {
                return 0;
            } else
            {
                return 60 - NotaFinal;
            }
        }
    }
}
