namespace CLI_Calculator.src
{
    internal class Calculator
    {
        internal static void Main() {
            
            while (true)
            {
                Console.Clear();
                Utilities.Print("\n========== Calculadora CLI ==========");

                decimal num1 = ReadDecimal("\nDigite um número: ");
                decimal num2 = ReadDecimal("\nDigite outro número: ");

                string op = ReadOperation("\nDefina a operação em sinal (+, -, x): ");

                decimal result = op switch
                {
                    "+" => num1 + num2,
                    "-" => num1 - num2,
                    "x" => num1 * num2,
                    _ => 0
                };

                Utilities.Print($"\n(Resultado: {result})");
                Utilities.Print("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        internal static decimal ReadDecimal(string prompt) {

            decimal value;
            while (true)
            {
                Utilities.Print(prompt);
                string input = Utilities.ReadInput();
                if (decimal.TryParse(input, out value))
                    break;
                Utilities.Print("\nEntrada inválida! Digite um número válido.");
            }
            return value;
        }

        internal static string ReadOperation(string prompt) {

            while (true)
            {
                Utilities.Print(prompt);
                string op = Utilities.ReadInput().Trim();
                if (op == "+" || op == "-" || op == "x")
                    return op;
                Utilities.Print("\nOperação inválida! Tente novamente.");
            }
        }
    }
}