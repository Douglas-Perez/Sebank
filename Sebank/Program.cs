using System.Security.AccessControl;

namespace Sebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new();
            while (true)
            {
                switch (Terminal.ExibirTerminal())
                {
                    case 1:
                        conta.ExibirSaldo();
                        Terminal.Esperar();
                        break;

                    case 2:
                        conta.Deposito();
                        conta.ExibirSaldo();
                        Terminal.Esperar();
                        break;

                    case 3:
                        conta.Sacar();
                        conta.ExibirSaldo();
                        Terminal.Esperar();
                        break;

                    case 4:
                        Console.WriteLine("Obrigado por usar nosso banco");
                        return;
                }
            }
        }
    }
}
