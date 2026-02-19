namespace CLI_Calculator;

public class Calculator
{
    internal static void Main() {

        loop:

        Print("\n========== Calculadora CLI ==========");

        Print("\nDigite um número");
        int num1 = Convert.ToInt32(ReadInput());

        Print("\nDigite outro número");
        int num2 = Convert.ToInt32(ReadInput());

        op_signal:
        Print("\nDefina a operação em sinal (+, -, x)");
        string op = ReadInput();

        int result = default;

        switch (op)
        {
            case "+":

                result = num1 + num2;
                break;
            case "-":

                result = num1 - num2;
                break;
            case "x":

                result = num1 * num2;
                break;
            default:

                Print("\n(Falha: Digite um sinal de operação válido!)");
                goto op_signal;
        }

        Print("\nResultado: " + result);

        goto loop;
    }

    internal static void Print(string msg) {

        Console.WriteLine(msg);
    }
    
    internal static string ReadInput() {

        string callback = Console.ReadLine();

        return callback;
    }
}