﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorCincoItens : Desconto
    {
        public Desconto proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return proximo.Desconta(orcamento);
        }
    }
}
