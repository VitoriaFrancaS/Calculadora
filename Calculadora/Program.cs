void ExibirLogo()
{
    Console.WriteLine(@"
█▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█
█▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█");

    Console.WriteLine("\nBem vinde ao que será sua melhor amiga na escola :)");

}

void ExibirMenu()
{
    ExibirLogo();
    Console.Write("Digite o primeiro número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("\nDigite o segundo número: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("\nEscolha a operação que deseja realizar +, -, /, *, raiz quadrada ou potência: ");
    string operacao = Console.ReadLine();

    double resultado = 0;

    switch (operacao)
    {
        case "+": resultado = num1 + num2;
            break;
        case "-": resultado = num1 - num2;
            break;
        case "/":
            if (num2 != 0)
                resultado = num1 / num2;
            else
                Console.WriteLine("Erro: Divisão por zero!");
            break;
        case "*": resultado = num1 * num2;
            break;
        case "raiz quadrada": resultado = Math.Sqrt(num1 * num2); 
            break;
        case "potência": resultado = Math.Pow(num1 / num2, 2);
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;

    }

    Console.Write($"\nA operação escolhida foi: {operacao}");
    Console.WriteLine($"\nO resultado da operação escolhida é: {resultado}");

    Console.WriteLine("\n\nPara voltar ao menu principal aperte qualquer tecla ");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}


ExibirMenu();

