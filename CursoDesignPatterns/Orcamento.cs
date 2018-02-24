using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        EstadoDeUmOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }
        public IList<Item> itens { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.itens = new List<Item>();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            itens.Add(item);
        }
    }
}
