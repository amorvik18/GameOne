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
      else if (noiseChoice == "YES")
      {
      Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");

      Console.Write("Type OPEN or KNOCK: ");

      string doorChoice = Console.ReadLine();

      doorChoice = doorChoice.ToUpper();

      if (doorChoice == "KNOCK")
      {
      Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\" \n \"Poor people have it. Rich people need it. \n If you eat it you die. What is it?\"");

      Console.WriteLine("Type your answer: ");

      string riddleAnswer = Console.ReadLine();
      
      riddleAnswer = riddleAnswer.ToUpper();
    }
  }
}