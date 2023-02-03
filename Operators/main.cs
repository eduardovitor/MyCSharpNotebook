using System;

class Program {
  public static void Main (string[] args) {
    // Os operadores funcionam praticamente da mesma forma que outras linguagens
    // Existem operadores matemáticos (+,*,...), lógicos (false,true), relacionais (==, >, <, ...) e unários (--, ++)
    var x = false;
    var n1 = 45;
    var n3 = 46;
    Console.WriteLine("n1: " + n1);
    Console.WriteLine("n3: " + n3);
    Console.WriteLine(n1 == -- n3); // Diminua o valor de n3 em 1 e depois compare com n1
  }
}