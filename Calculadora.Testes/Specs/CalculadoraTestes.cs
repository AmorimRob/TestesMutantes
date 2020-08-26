using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Calculadora.Testes.Specs
{
    public class CalculadoraTestes
    {
        [Test]
        public void DeveAplicarTaxaDe10ReaisParaCadaProdutoQueForLançamentoNoValorTotal()
        {
            var produtos = new List<Produto> {
                new Produto { Nome = "Óculos", Lançamento = false, Valor = 10m },
                new Produto { Nome = "Carteira", Lançamento = true, Valor = 25m }
            };

            var resultadoEsperado = 45m;

            var calculadora = new Calculadora();

            var resultado = calculadora.CalcularTotalDoPedido(produtos);

            resultado.Should().Be(resultadoEsperado);
        }

        [Test]
        public void DeveAplicarDescontoDe10ReaisQuandoValorTotalForMaiorQue100()
        {
            var produtos = new List<Produto> {
                new Produto { Nome = "Óculos", Valor = 60m },
                new Produto { Nome = "Carteira", Valor = 60m }
            };

            var resultadoEsperado = 110m;

            var calculadora = new Calculadora();

            var resultado = calculadora.CalcularTotalDoPedido(produtos);

            resultado.Should().Be(resultadoEsperado);
        }

        //[Test]
        //public void NãoDeveAplicarDescontoQuandoValorTotalForIgualACem()
        //{
        //    var produtos = new List<Produto> {
        //        new Produto { Nome = "Óculos", Valor = 50m },
        //        new Produto { Nome = "Carteira", Valor = 50m }
        //    };

        //    var resultadoEsperado = 100m;

        //    var calculadora = new Calculadora();

        //    var resultado = calculadora.CalcularTotalDoPedido(produtos);

        //    resultado.Should().Be(resultadoEsperado);
        //}

        [Test]
        public void DeveAplicarDescontoDe20ReaisQuandoCompraTiverMaisDe5ItensEValorForMaiorQueVinte()
        {
            var produtos = new List<Produto> {
                new Produto { Nome = "Óculos", Valor = 10m },
                new Produto { Nome = "Carteira", Valor = 10m },
                new Produto { Nome = "Carteira", Valor = 10m },
                new Produto { Nome = "Carteira", Valor = 10m },
                new Produto { Nome = "Carteira", Valor = 10m },
                new Produto { Nome = "Carteira", Valor = 10m }
            };

            var resultadoEsperado = 40m;

            var calculadora = new Calculadora();

            var resultado = calculadora.CalcularTotalDoPedido(produtos);

            resultado.Should().Be(resultadoEsperado);
        }
    }
}
