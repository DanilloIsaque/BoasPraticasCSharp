using Alura.Adopet.Console.Utils;

namespace Alura.Adopet.Console.Comandos
{
    internal class Show : IComando
    {
        public Task ExecutarAsync(string[] args)
        {
            this.ExibeConteudoArquivo(args[1]);
            return Task.CompletedTask;
        }

        private void ExibeConteudoArquivo(string caminhoDoArquivoASerExibido)
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo();
            var listaDepets = leitor.RealizaLeitura(caminhoDoArquivoASerExibido);
            foreach (var pet in listaDepets)
            {
                System.Console.WriteLine(pet);
            }


        }
    }
}