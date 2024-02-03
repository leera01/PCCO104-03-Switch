using System;

class Program 
{
  public static void Main (string[] args) 
  {
    char letter = 'Z';

    switch (letter) {
      case 'A':
        Console.WriteLine($"{letter} is for Apple.");
        break;
      case 'B':
        Console.WriteLine($"{letter} is for Banana.");
        break;
      case 'C':
        Console.WriteLine($"{letter} is for Cranberry.");
        break;
      case 'D':
        Console.WriteLine($"{letter} is for Durian.");
        break;
      default:
        Console.WriteLine("Cannot find fruit.");
        break;
    }
  }
}