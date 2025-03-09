using System;
using System.Collections.Generic;
using System.Drawing;
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
            Console.WriteLine($"Saldo atual: R$ {Saldo}");
        }

        public void Deposito()
        {
            float valor;
            bool teste;

            do
            {
                Console.WriteLine("Digite o valor que deseja depositar.");
                ExibirSaldo();
                Console.Write("R$ ");
                teste = float.TryParse(Console.ReadLine(), out valor);
                Console.Clear();
                if (!teste || valor < 0)
                {
                    Console.WriteLine("Erro. Valor inválido!");
                }
            } while (!teste || valor < 0);

            Saldo += valor;
        }

        public void Sacar()
        {
            float valor;
            bool teste;
            do
            {
                Console.WriteLine("Digite o valor que deseja sacar.");
                ExibirSaldo();
                Console.Write("R$ ");
                teste = float.TryParse(Console.ReadLine(), out valor);
                Console.Clear();
                if (!teste || valor < 0)
                {
                    Console.WriteLine("Erro. Valor inválido!");
                }
                if (valor > Saldo)
                {
                    Console.WriteLine($"Erro. A quantia solicitada ultrapassa o saldo atual em R${valor - Saldo}");
                }
            } while (!teste || valor < 0 || valor > Saldo);
            Saldo -= valor;
        }
    }
}
