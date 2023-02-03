using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Hi, this program will help you calculate your average grade!");
    Console.WriteLine("This way you can know if you are approved on a subject or if you failed");
    Console.WriteLine("Let's start!");
    Console.WriteLine("Type the first grade: ");
    double grade1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Type the second grade: ");
    double grade2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Type the third grade: ");
    double grade3 = double.Parse(Console.ReadLine());
    var average_grade = (grade1+grade2+grade3)/3;
    Console.WriteLine("Your average grade was {0}",average_grade);
    if(average_grade>=7){
        Console.WriteLine("You are approved!");
    }
    else {
        Console.WriteLine("You failed!");    
    }
  }
}