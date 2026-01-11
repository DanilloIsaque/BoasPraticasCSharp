using Alura.Adopet.Console.Utils;
using Alura.Adopet.Console.Comandos;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Alura.Adopet.Tests
{
    public class GeraDocumentacaoTest
    {
        [Fact]
        public void QuandoExistemComandosDeveRetornarDicionarioNaoVazio()
        {
            //Arrange
            Assembly assemblyComOTipoDocComando = Assembly.GetAssembly(typeof(DocComando))!;

            //Act
            Dictionary<string, DocComando> dicionario =
                  DocumentacaoDoSistema.ToDictionary(assemblyComOTipoDocComando);

            //Assert            
            Assert.NotNull(dicionario);
            Assert.NotEmpty(dicionario);
            Assert.Equal(4, dicionario.Count);

        }
    }
}
