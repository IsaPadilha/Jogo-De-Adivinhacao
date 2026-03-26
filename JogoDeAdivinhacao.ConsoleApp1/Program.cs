using System.Security.Cryptography;

bool jogoDeveContinuar = true;

while (jogoDeveContinuar == true)
{
    int pontuacao = 1000;

    Console.Clear();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("Escolha o nível de dificuldade: ");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("1- Fácil (número de 1 à 20! 10 tentativas)");
    Console.WriteLine("2- Médio (número de 1 à 50! 5 tentativas)");
    Console.WriteLine("3- Difícil (número de 1 à 100! 3 tentativas)");
    Console.WriteLine("--------------------------------");

    Console.WriteLine("Digite a sua escolha: ");
    string opcaoDificuldade = Console.ReadLine();

    int numeroAleatorio;
    int tentativaMaxima;

    switch (opcaoDificuldade)
    {
        case "1":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
            tentativaMaxima = 10;
            break;
        case "2":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);
            tentativaMaxima = 5;
            break;
        case "3":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);
            tentativaMaxima = 3;
            break;
        default:
            Console.WriteLine("Selecione uma opção válida!");
            Console.ReadLine();
            continue;
    }

    int[] numerosDigitados = new int[tentativaMaxima];
    int contadorNumerosDigitados = 0;

    for (int tentativaAtual = 1; tentativaAtual <= tentativaMaxima; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Tentativa {tentativaAtual} de {tentativaMaxima} | Pontos: {pontuacao}");
        Console.WriteLine("------------------------------------------------");

        Console.Write("Digite um número: ");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());

        bool numeroEstaRepetido = false;
        for (int i = 0; i < contadorNumerosDigitados; i++)
        {
            if (numerosDigitados[i] == numeroDigitado)
            {
                numeroEstaRepetido = true;
                break;
            }
        }

        if (numeroEstaRepetido)
        {
            Console.WriteLine("Você já digitou esse número!");
            Console.ReadLine();
            tentativaAtual--;
            continue;
        }

        numerosDigitados[contadorNumerosDigitados] = numeroDigitado;
        contadorNumerosDigitados++;

        if (numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine($"Parabéns! Você acertou com {pontuacao} pontos!");
            break;
        }

        int diferenca;
        if (numeroDigitado > numeroAleatorio)
        {
            Console.WriteLine("O número digitado foi MAIOR!");
            diferenca = numeroDigitado - numeroAleatorio;
        }
        else
        {
            Console.WriteLine("O número digitado foi MENOR!");
            diferenca = numeroAleatorio - numeroDigitado;
        }


        if (diferenca >= 10)
        {
            pontuacao -= 100;
        }
        else if (diferenca >= 5)
        {
            pontuacao -= 50;
        }
        else
        {
            pontuacao -= 20;
        }

        if (tentativaAtual == tentativaMaxima)
        {
            Console.WriteLine($"Fim de jogo! O número era {numeroAleatorio}.");
        }

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }

    Console.WriteLine();
    Console.Write("Deseja continuar? (s/n): ");
    string opcaoCont = Console.ReadLine();


    if (opcaoCont != "s" && opcaoCont != "S")
    {
        jogoDeveContinuar = false;
    }
}