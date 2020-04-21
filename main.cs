using System;

namespace Snake 
{
class MainClass {
    public static void Main (string[] args) {
    
    Console.WriteLine("Hello Stranger! Please tell me your name.");
    string userName = Console.ReadLine();
    Console.WriteLine ($"Welcome in GameOne {userName}. Press enter to continue...");
    Console.ReadLine();
    }
  }
}