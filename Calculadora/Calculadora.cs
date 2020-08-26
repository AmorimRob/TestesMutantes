using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora
{
    public class Calculadora : ICalculadora
    {
        public Calculadora()
        {
        }

        public decimal CalcularTotalDoPedido(IReadOnlyCollection<Produto> produtos)
        {
            var valorTotal = 0m;

            foreach(var produto in produtos)
            {
                if (produto.Lançamento)
                    valorTotal += 10;

                valorTotal += produto.Valor;
            }

            if(valorTotal > 100)
            {
                valorTotal -= 10;
            }

            if((produtos.Count > 5 && valorTotal > 20))
            {
                valorTotal -= 20;
            }

            return valorTotal;
        }
    }
}
