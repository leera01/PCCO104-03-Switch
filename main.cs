using System;

class Program 
{
  public static void Main (string[] args) 
  {
    char letter = 'A';

    switch (letter) {
      case 'A':
        Console.WriteLine($"{letter} is for Alpha.");
        break;
      case 'B':
        Console.WriteLine($"{letter} is for Bravo.");
        break;
      case 'C':
        Console.WriteLine($"{letter} is for Charlie.");
        break;
      case 'D':
        Console.WriteLine($"{letter} is for Delta.");
        break;
      default:
        Console.WriteLine("Cannot find fruit.");
        break;
    }
  }
}