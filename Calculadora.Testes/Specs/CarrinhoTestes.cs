using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Calculadora.Testes.Specs
{
    public class CarrinhoTestes
    {
        [Test]
        public void DeveAdicionarProdutoAoCarrinhoQuandoValorForMaiorDoQue10()
        {
            var carrinho = new Carrinho();

            var produtos = new List<Produto>();
            var produto = new Produto { Valor = 15 };

            carrinho.AdicionarItens(produto, produtos);

            produtos.Count.Should().Be(1);
        }
    
    }
}
