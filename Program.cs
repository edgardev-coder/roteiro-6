using System.Text;

namespace ExcecoesCSharp
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== Aula 06 - Tratamento de Exceções ===");
                Console.WriteLine("2 - Conversão de temperatura");
                Console.WriteLine("3 - Entrada de número inteiro");
                Console.WriteLine("4 - Exceção personalizada para idade");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha: ");

                string opcao = Console.ReadLine();
                if (opcao == null)
                {
                    return;
                }

                Console.WriteLine();

                switch (opcao.Trim())
                {
                    case "2":
                        Exercicio2.Executar();
                        break;
                    case "3":
                        Exercicio3.Executar();
                        break;
                    case "4":
                        Exercicio4.Executar();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
