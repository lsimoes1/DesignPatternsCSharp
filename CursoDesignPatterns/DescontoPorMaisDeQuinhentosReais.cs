using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public Desconto proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
            {
                return orcamento.Valor * 0.7;
            }

            return proximo.Desconta(orcamento);
        }
    }
}
