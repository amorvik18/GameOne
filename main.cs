using System;

namespace GameOne 
{
  class MainClass 
  {
    static void Main (string[] args) 
    {
    // Start by asking fo the user's name:
    
    Console.Write("What is your name?: ");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello, {name}! Welcome to our story.");
    Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
    Console.Write("Please type \"YES\" or \"NO\": ");
    
    string noiseChoice = Console.ReadLine();
    noiseChoice = noiseChoice.ToUpper();
      
      if (noiseChoice == "NO")
      {
      Console.WriteLine("Not much of an adventure if we don't leave our room! \n THE END.\n Press any key to close the game.");
      Console.ReadLine();
      }
    }
  }
}