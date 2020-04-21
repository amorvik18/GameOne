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

          if (riddleAnswer == "NOTHING")
          {
            Console.WriteLine("The door opens and NOTHING is there. \n You turn off the light and run back to your \n room and lock the door. \n THE END.\n Press any key to close the game");

            Console.ReadLine();
          }
          else
          {
            Console.WriteLine("You answered incorrectly. The door doesn't open. \n THE END.\n Press any key to close the game.");

            Console.ReadLine();
          }
        }
        else if (doorChoice == "OPEN")
        {
          Console.WriteLine("The door is locked! See if \n one of your three keys will open it.");

          Console.Write("Enter a number (1-3): ");

          string keyChoice = Console.ReadLine();

          switch (keyChoice)
          {
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice! \n The door opens and NOTHING is there. Strange... \n THE END. \n Press any key to close the game.");

              Console.ReadLine();
              break;
            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open. \n THE END. \n Press any key to close the game.");

              Console.ReadLine();
              break;
            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open.\n THE END. \n Press any key to close the game.");
              
              Console.ReadLine();
              break;
          }
        }
      }  
    }
  }
}