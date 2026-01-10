using Alura.Adopet.Console.Models;
using Alura.Adopet.Console.Services;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "list",
       documentacao: "adopet list comando que exibe no terminal o conteúdo cadastrado na base de dados da AdoPet.")]
    internal class List : IComando
    {
        public Task ExecutarAsync(string[] args)
        {
            return this.ListaDadosPetsDaAPIAsync();
        }


        public async Task ListaDadosPetsDaAPIAsync()
        {
            var httpListPet = new HttpClientPet();
            IEnumerable<Pet>? pets = await httpListPet.ListPetsAsync();
            System.Console.WriteLine("----- Lista de Pets importados no sistema -----");
            foreach (var pet in pets)
            {
                System.Console.WriteLine(pet);
            }
        }

    }
}