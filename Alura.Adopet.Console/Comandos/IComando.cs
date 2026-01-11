using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Adopet.Console.Comandos
{
    internal interface IComando
    {
        Task ExecutarAsync(string[] args);
    }
}
