using System;


class Program {
  public static void Main (string[] args) {
    string mystring = "Oi, eu sou uma string";
    Console.WriteLine(mystring);
    // Testando tipos
    int x = 2;
    double y = 3.5;
    double res = x * y;
    bool teste = true;
    var inf_var = 2;
    Console.WriteLine(res);
    Console.WriteLine(teste);
    // Concatenando variáveis 
    Console.WriteLine("O resultado da operação foi "+ res);
    Console.WriteLine("Variável declarada por inferência: "+inf_var);
  }
}