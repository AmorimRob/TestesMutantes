using System;
using System.Collections.Generic;

namespace Calculadora
{
    public class Carrinho
    {
        public void AdicionarItens(Produto produto, List<Produto> produtos)
        {
            if (produto.Valor >= 10)
                produtos.Add(produto);
        }
    }
}
