using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sebank
{
    class Terminal
    {
        public int ExibirTerminal()
        {
            int acao;
            bool teste;
            do
            {
                Console.WriteLine("1 -> Ver saldo da conta.");
                Console.WriteLine("2 -> Fazer um depósito.");
                Console.WriteLine("3 -> Sacar um valor.");
                Console.WriteLine("4 -> Sair");
                teste = int.TryParse(Console.ReadLine(), out acao);
                Console.Clear();
                if (acao > 4 || acao < 1 || !teste)
                {
                    Console.WriteLine("Por favor, escolha uma das ações abaixo:\n");
                }
            } while (acao > 4 || acao < 1 || !teste);
            return acao;
        }

        public void Esperar()
        {
            Console.WriteLine("\nPressione Enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
