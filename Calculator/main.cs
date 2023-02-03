using System;

class Program {
  public static void printMenu(){
      Console.WriteLine("This program calculates the sum of two numbers. \n0 - Exit\n1 - Calculate the sum of two numbers\n");
  }
  public static void readAndCalculate(){
    double n1,n2;
    Console.WriteLine("Type the first number: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Type the second number: ");
    n2 = double.Parse(Console.ReadLine());
    Console.WriteLine("The result is {0} \n",n1+n2);
  }
  public static void Main (string[] args) {
    // Calculadora de dois números
    bool state = true;
    while(state){
        printMenu();
        var op = int.Parse(Console.ReadLine());
        if(op==0){
          state = false;  
        }
        else if(op==1){
            readAndCalculate();
        }
    }
  }
}