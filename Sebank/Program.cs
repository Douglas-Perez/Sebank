using System.Security.AccessControl;

namespace Sebank
{
    internal class Program
    {
        public static bool continuar = true;
        public static int acao = 0;
        public static bool teste= true;
        public static float quantia;

        public static ContaCorrente conta = new ContaCorrente();
        public static void Espera()
        {
            Console.WriteLine("\nPressione Enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                quantia = 0;

                Console.WriteLine("Bem-vindo ao Sebank!\nO que gostaria de fazer?\n");
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

                switch (acao)
                {
                    case 1:
                        conta.ExibirSaldo();
                        Espera();
                        break;

                    case 2:
                        conta.Deposito();
                        conta.ExibirSaldo();
                        Espera();
                        break;

                    case 3:
                        conta.Sacar();
                        conta.ExibirSaldo();
                        Espera();
                        break;

                    case 4:
                        Console.WriteLine("Obrigado por usar nosso banco");
                        return;
                }
            }
        }
    }
}
