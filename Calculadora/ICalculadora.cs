using System;
using System.Collections.Generic;

namespace Calculadora
{
    public interface ICalculadora
    {
        decimal CalcularTotalDoPedido(IReadOnlyCollection<Produto> pedido);
    }
}
