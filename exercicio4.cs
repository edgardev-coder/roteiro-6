namespace ExcecoesCSharp
{
    public static class Exercicio4
    {
        public static void VerificarIdade(int idade)
        {
            if (idade < 18)
            {
                throw new IdadeInvalidaException("Idade mínima para acesso é 18 anos.");
            }

            Console.WriteLine("Acesso permitido.");
        }

        public static void Executar()
        {
            Console.WriteLine("=== Exercício 4: Exceção personalizada para idade ===");
            Console.Write("Digite a idade: ");
            string entrada = Console.ReadLine() ?? "";

            try
            {
                int idade = int.Parse(entrada);
                VerificarIdade(idade);
            }
            catch (IdadeInvalidaException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: digite a idade como um número inteiro.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: número fora do intervalo permitido.");
            }
        }
    }
}
