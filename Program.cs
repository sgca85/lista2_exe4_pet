Console.Clear();

string Espécie;
string Raça;
string Alcunha;
int Idade;
string Cor;

Console.WriteLine("Bem Vindo ao Pet Hotel Amigão!");
Thread.Sleep(2000);

Console.WriteLine("Qual a espécie do seu pet?");
Espécie = Console.ReadLine()!;
Thread.Sleep(1000);

Console.WriteLine("Qual a raça do seu pet?");
Raça = Console.ReadLine()!;
Thread.Sleep(1000);

Console.WriteLine("Qual o nome do seu pet?");
Alcunha = Console.ReadLine()!;
Thread.Sleep(1000);

Console.WriteLine("Qual a idade do seu pet?");
Idade = int.Parse(Console.ReadLine()!);
Thread.Sleep(1000);

Console.WriteLine("Qual a cor do seu pet?");
Cor = Console.ReadLine()!;
Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+=========================================================+");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("|                 PET HOTEL AMIGÃO                        |");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+=========================================================+");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write($"| Espécie:{Espécie.ToUpper().PadLeft(16,'.')}");
Console.WriteLine($"| Raça:{Raça.ToUpper().PadLeft(24,'.')} |");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+=========================================================+");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"| Atende pela alcunha de:{Alcunha.ToUpper().PadLeft(32,'.')} |");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write($"| Idade: {Idade.ToString("00")} ano(s) ");
Console.WriteLine($"| Raça:{Raça.ToUpper().PadLeft(31,'.')} |");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+=========================================================+");
Console.ResetColor();
