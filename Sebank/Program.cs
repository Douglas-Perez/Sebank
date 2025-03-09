using System.Security.AccessControl;

namespace Sebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new();
            Terminal terminal = new();
            while (true)
            {

                Console.WriteLine("Bem-vindo ao Sebank!\nO que gostaria de fazer?\n");
                
                switch (terminal.ExibirTerminal())
                {
                    case 1:
                        conta.ExibirSaldo();
                        terminal.Esperar();
                        break;

                    case 2:
                        conta.Deposito();
                        conta.ExibirSaldo();
                        terminal.Esperar();
                        break;

                    case 3:
                        conta.Sacar();
                        conta.ExibirSaldo();
                        terminal.Esperar();
                        break;

                    case 4:
                        Console.WriteLine("Obrigado por usar nosso banco");
                        return;
                }
            }
        }
    }
}
