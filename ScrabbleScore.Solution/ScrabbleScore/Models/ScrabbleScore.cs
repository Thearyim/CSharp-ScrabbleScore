using System.Collections.Generic;

namespace ScrabbleScore
{
    public class ScrabbleScore
    {
        public int GetScrabbleScore(string word)
        {

          // Takes a word and returns the Scrabble score for that word
          // values of letters in Scrabble:
          // Letters                         Value
          // A, E, I, O, U, L, N, R, S, T      1
          // D, G                              2
          // B, C, M, P                        3
          // F, H, V, W, Y                     4
          // K                                 5
          // J, X                              8
          // Q, Z                              10

            int score = 0;
            string wordUC = word.ToUpper();
            for (int i = 0; i < wordUC.Length; i++)
            {
                char letter = wordUC[i];

                if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'L' || letter == 'N' || letter == 'R' || letter == 'S' || letter == 'T')
                {
                    score +=1;
                }
                else if (letter == 'D' || letter == 'G')
                {
                    score +=2;
                }
                else if (letter == 'B' || letter == 'C' || letter == 'M' || letter == 'P')
                {
                    score +=3;
                }
                else if (letter == 'F' || letter == 'H' || letter == 'V' || letter == 'W' || letter == 'Y')
                {
                    score +=4;
                }
                else if (letter == 'K')
                {
                    score +=5;
                }
                else if (letter == 'J' || letter == 'X')
                {
                    score +=8;
                }

                else if (letter == 'Q' || letter == 'Z')
                {
                    score +=10;
                }

            }

            return score;
        }
    }
}
