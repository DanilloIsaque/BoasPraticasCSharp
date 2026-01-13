using Alura.Adopet.Console.Models;
using Alura.Adopet.Console.Services;
using Alura.Adopet.Console.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace Alura.Adopet.Console.Comandos
{
     public class Import : IComando
    {
        private readonly HttpClientPet clientPet;

        private readonly LeitorDeArquivo leitor;

        public Import(HttpClientPet clientPet, LeitorDeArquivo leitor)
        {
            this.clientPet = clientPet;
            this.leitor = leitor;
        }

        public async Task ExecutarAsync(string[] args)
        {
            await this.ImportacaoArquivoPetAsync(caminhoDoArquivoDeImportacao: args[1]);
        }

        private async Task ImportacaoArquivoPetAsync(string caminhoDoArquivoDeImportacao)
        {
            List<Pet> listaDePet = leitor.RealizaLeitura();
            foreach (var pet in listaDePet)
            {
                System.Console.WriteLine(pet);
                try
                {
                    await clientPet.CreatePetAsync(pet);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
            System.Console.WriteLine("Importação concluída!");
        }
    }
}