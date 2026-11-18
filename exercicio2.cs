using System.Globalization;

namespace ExcecoesCSharp
{
    public static class Exercicio2
    {
        public static float ConverterParaCelsius(string entrada)
        {
            string texto = (entrada ?? "").Trim().Replace(',', '.');

            if (!float.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out float temperatura)
                || !float.IsFinite(temperatura))
            {
                throw new FormatException("O valor digitado não representa uma temperatura válida.");
            }

            return temperatura;
        }

        public static void Executar()
        {
            Console.WriteLine("=== Exercício 2: Conversão de temperatura ===");

            float temperatura = 0;
            bool valido = false;

            while (!valido)
            {
                Console.Write("Digite a temperatura em Celsius: ");
                string entrada = Console.ReadLine();

                try
                {
                    temperatura = ConverterParaCelsius(entrada);
                    valido = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message} Tente novamente.");
                }
            }

            Console.WriteLine($"Temperatura registrada: {temperatura.ToString("0.##", CultureInfo.CurrentCulture)} °C");
        }
    }
}
