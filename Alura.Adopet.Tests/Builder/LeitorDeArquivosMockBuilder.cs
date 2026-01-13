using Alura.Adopet.Console.Models;
using Alura.Adopet.Console.Utils;
using Moq;

namespace Alura.Adopet.Testes.Builder
{
    internal static class LeitorDeArquivosMockBuilder
    {
        public static Mock<LeitorDeArquivo> GetMock(List<Pet> listaDePet)
        {
            var leitorDeArquivo = new Mock<LeitorDeArquivo>(MockBehavior.Default,
                It.IsAny<string>());

            leitorDeArquivo.Setup(_ => _.RealizaLeitura()).Returns(listaDePet);

            return leitorDeArquivo;
        }
    }
}
