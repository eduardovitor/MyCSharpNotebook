using System;
// Lembrar que C# possui structs e classes, a diferença está na forma de atribuição de valores. Structs atribuem valor por cópia. Classes atribuem por referênica
// É possível passar por referência. Além disso, parâmetros padrão (como os de Python) são uma opção. 
// C# possui enumerações que podem servir para resolver alguns problemas
// Não coloquei aqui partes avançadas do curso como Actions, Funcs, LINQ, extensões e delegate
class Program {
  public static void Main (string[] args) {
    Pessoa p = new Pessoa();
    p.setNome("Vitor");
    Console.WriteLine(p.getNome());  
    Aluno a = new Aluno();
    a.setMatricula("123");
    Console.WriteLine(a.getMatricula());
    Professor prof = new Professor();
    prof.setFormacao("Mestrado");
    Console.WriteLine(prof.getFormacao());
  }
}