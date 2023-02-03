using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o seu nome"); // print do C#
    string nome = Console.ReadLine(); // input() do C#
    Console.WriteLine("Digite o seu número de telefone: ");
    double num_telefone = Double.Parse(Console.ReadLine());
    Console.WriteLine("O nome é " +nome);
    Console.WriteLine("O número de telefone é " +num_telefone);
   }
}