using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class Game
    {
        // Game states
        
        (int X, int Y) playerLocation;
        private bool winStatus = false;
        private bool gameOn = true;
        private bool _validBoard = false;
        Board board = new Board();
        Dialogue dialogue = new Dialogue();
        Fountain fountain = new Fountain();



        //functions
        public void Play()
        {
            Player player = new Player();
            UserInputHandler userInputHandler = new UserInputHandler();
            dialogue.Introduction();


            while (userInputHandler.InputValidationCheckDifficulty(Console.ReadLine()) == false) //this must user the UserInputHandler rather than Board because Board has not been instantiated.
            {
                Dialogue.SelectBoardSize();
                userInputHandler.SetUserInput(Console.ReadLine());
                if (userInputHandler.InputValidationCheckDifficulty(userInputHandler.GetUserInput()) == true) ;
                {
                    board.SetBoardSize(userInputHandler.GetSize());
                    board.BoardBuilder(board.GetSize(), fountain);
                }

            }

            /* while (winStatus == false)
             {
                 Dialogue.PlayerMove();
                 player.SetPlayerLocation(userInputHandler.InputValidationCheckPlayerMove(player.GetPlayerXLocation(), player.GetPlayerYLocation(), Console.ReadLine(), board.GetSize()));
                 dialogue.PlayerStatus(player.GetPlayerYLocation(),/*roomtrait*//*, fountain.GetFountainOn());


             }




         }

         public bool WinCheck()
         {
             if (playerLocation == (0, 0) && fountain.GetFountainOn() == true)
             {
                 winStatus = true;
             }

             if (winStatus == true)
             {
                 gameOn = false;
             }
             return gameOn;

         }

         //getters and setters
         public bool GetGameOn()
         {
             return gameOn;
         }

         public void GetPlayerLocation(int X, int Y)
         {
             playerLocation.X = X;
             playerLocation.Y = Y;
         }*/



        }
    }
}
