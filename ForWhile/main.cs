using System;

class Program {
  public static void Main (string[] args) {
    int test_w = 1;
    while(test_w<=10){
        Console.WriteLine("Test value = "+test_w);
        test_w++;
    }
    int test_f;
    for(test_f=1;test_f<=10;test_f++){
        Console.WriteLine("Second test value = "+test_f);
    }
  }
}