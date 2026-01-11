using Alura.Adopet.Console.Services;

namespace Alura.Adopet.Tests
{
    public class HttpClientPetTest
    {
        [Fact]
        public async Task ListaPetDeveRetornarUmaListaNaoVazia()
        {
            // Arrange configuracao do projeto
            var clientPet = new HttpClientPet(uri:"//localhost:1111");
            // Act acao
            var lista = await clientPet.ListPetsAsync();
            // Assert verificar o resultado obtido
            Assert.NotNull(lista);
            Assert.NotEmpty(lista);
        }

        [Fact]
        public async Task QuandoApiForaDeveRetornarUmaExcecao()
        {
            // Arrange configuracao do projeto
            var clientPet = new HttpClientPet();
            // Act + assert
            await Assert.ThrowsAnyAsync<Exception>(() => clientPet.ListPetsAsync());
        }
    }
}
