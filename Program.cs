Random numAleatorio = new Random();
int numeroSecreto = numAleatorio.Next(1, 101);

Console.WriteLine(">>> - JOGO DO NÚMERO SECRETO - <<<\n");

do {
    Console.WriteLine("Digite um número entre 1 e 100: ");
    int randomNum = int.Parse(Console.ReadLine()!);

    if (randomNum == numeroSecreto) {
        Console.WriteLine("Parabéns! Você acertou!");
        break;
    } else if (randomNum < numeroSecreto) {
        Console.WriteLine("O número é maior! Tente novamente");
    } else {
        Console.WriteLine("O número é menor! Tente novamente.");
    }

} while(true);

Console.WriteLine("Muito bem! O jogo finalizará agora...");
