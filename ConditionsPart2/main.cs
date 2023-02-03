using System;

class Program {
  public static void Main (string[] args) {
   Console.WriteLine("Type an option (1,2,3): ");
   int.TryParse(Console.ReadLine(), out int op);
   switch(op) {
       case 1:
            Console.WriteLine("The chosen option was 1");
            break;
        case 2:
            Console.WriteLine("The chosen option was 2");
            break;
        case 3:
            Console.WriteLine("The chosen option was 3");
            break;
        default:
            Console.WriteLine("The option is not available");
            break;
    }
  }
}