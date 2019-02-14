using System;
using System.Collections.Generic;


namespace ScrabbleScore
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter text to have it transformed into ScrabbleScore: ");
      string userText = Console.ReadLine();
      ScrabbleScore scrabbleScore = new ScrabbleScore();
      int result = scrabbleScore.GetScrabbleScore(userText);
      Console.WriteLine("ScrabbleScore: " + result);
    }
  }

}
