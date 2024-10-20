using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTestes
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTestes()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveValidarStringDe5Caracteres()
        {
            //Arrange
            string caracteres = "texto";

            //Act

            int resultado = _validacoes.ContarCaracteres(caracteres);

            //Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void DeveValidarStringDe15Caracteres()
        {
            //Arrange
            string caracteres = "texto de quinze";

            //Act

            int resultado = _validacoes.ContarCaracteres(caracteres);

            //Assert
            Assert.Equal(15, resultado);
        }
    }
}