using System.Security.Cryptography;
Console.WriteLine("-------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("-------------------");

Console.WriteLine();
Console.WriteLine("Digite um número:");
string strNumeroDigitado = Console.ReadLine();

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21); // gerar um número aleatório entre 1 e 20

Console.WriteLine("O número digitado foi: " + numeroAleatorio);
Console.ReadLine();