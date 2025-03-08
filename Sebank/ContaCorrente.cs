using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sebank
{
    internal class ContaCorrente
    {
        string Numero = "Numero do Usuario";
        string Titular = "Nome do Usuario";
        public float Saldo = 1000.00F;

        

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo}");
        }

        public void Deposito(float deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(float saque)
        {
            Saldo -= saque;
        }
    }
}
