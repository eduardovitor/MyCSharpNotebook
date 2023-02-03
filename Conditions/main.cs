using System;

class Program {
  public static void Main (string[] args) {
    int num1 = 4;
    int num2 = 4;
    if(num1>num2){
        Console.WriteLine("Number 1 is greater than number 2");
    }
    else if(num2>num1){
      Console.WriteLine("Number 2 is greater than number 1");      
    }
    else{
      Console.WriteLine("NUmber 1 and 2 are equal");
    }
  }
}