﻿using System;

namespace csharp_number_guesser
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user name
      Console.WriteLine("What is your name?");
      // Get user input
      string userName = Console.ReadLine();

      // Start game
      Console.WriteLine($"Hello, {userName}, let's play the number guessing game!");

      // Set the correct number
      int correctNumber = 7;
      // Set guess
      int guess = 0;

      // Ask user to guess a number
      Console.WriteLine("Guess a number between 1 and 10!");
      // Play rounds of game
      while (guess != correctNumber)
      {
        string userGuess = Console.ReadLine();
        // Change guess to int and store as guess
        guess = Int32.Parse(userGuess);
        // Match guess to correctNumber
        if (guess != correctNumber)
        {
          // Change text color
          Console.ForegroundColor = ConsoleColor.Red;
          // Wrong guess message
          Console.WriteLine("Wrong number! Guess again!");
          // Reset text color
          Console.ResetColor();
        }
      }
      // Change text color
      Console.ForegroundColor = ConsoleColor.Green;
      // Correct guess message
      Console.WriteLine("Correct number! Good job!");
      // Reset text color
      Console.ResetColor();


    }
  }
}
