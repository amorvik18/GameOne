using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Hello Stranger! Please tell me your name.");
    string name = Console.ReadLine();
    Console.WriteLine ($"Welcome in GameOne {name}. Please press enter to start the game.");
    Console.ReadLine();
  }
}