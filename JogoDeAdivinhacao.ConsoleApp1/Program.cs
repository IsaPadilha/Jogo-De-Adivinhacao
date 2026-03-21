using System.Security.Cryptography;

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21); // gerar um número aleatório entre 1 e 20

bool jogoDeveContinuar = true;

while (jogoDeveContinuar == true)
{
    Console.WriteLine("-------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("-------------------");

    Console.WriteLine();
    Console.Write("Digite um número: ");
    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

    if (numeroDigitado == numeroAleatorio)
    {
        Console.WriteLine("Parabéns, você acertou! O número é " + numeroAleatorio);
    }
    else if (numeroDigitado < numeroAleatorio)
    {
        Console.WriteLine("O número digitado foi menor do que o número secreto!");
    }
    else
    {
        Console.WriteLine("O número digitado foi maior do que o número secreto!");
    }

    Console.WriteLine();
    Console.Write("Deseja continuar? (s/n): ");
    string opcaoCont = Console.ReadLine();

    if (opcaoCont != "s" && opcaoCont != "S")
    {
        jogoDeveContinuar = false;
    }
}
