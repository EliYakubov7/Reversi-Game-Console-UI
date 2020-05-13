using System;
using System.Collections.Generic;
using System.Text;

// $G$ RUL-001 (-20) Wrong mail subject format.
// $G$ RUL-004 (-20) Wrong zip name format / folder name format

// $G$ SFN-004 (-10) Unable to play versus a human player.
// $G$ SFN-005 (-10) Unable to play versus a computer player.
// $G$ SFN-013 (-7) Invalid input is not handled as required. - first player name

// $G$ CSS-999 (-10) Coding standards are poorly kept throughout the solution.

namespace Ex02_Othelo
{
    public class Program
    {
        public static void Main()
        {
            GameUi newGame = new GameUi();
            newGame.GameMenu();
        }
    }
}
