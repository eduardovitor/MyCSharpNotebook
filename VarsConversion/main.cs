using System;

class Program {
  public static void Main (string[] args) {
    int x = 2;
    double y = x; // Conversão Implícita
    Console.WriteLine(y);
    double z = (double) x; // Conversão Explícita
    Console.WriteLine(z);
    double t = Convert.ToDouble(x); // Conversão por meio da classe Convert
    Console.WriteLine(t);
  }
}