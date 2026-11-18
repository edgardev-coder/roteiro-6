namespace ExcecoesCSharp
{
    public static class Exercicio3
    {
        public static void Executar()
        {
            Console.WriteLine("=== Exercício 3: Entrada de número inteiro ===");
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine() ?? "";

            try
            {
                int numero = int.Parse(entrada);
                Console.WriteLine($"Você digitou: {numero}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número fora do intervalo permitido para um inteiro.");
            }
        }
    }
}
