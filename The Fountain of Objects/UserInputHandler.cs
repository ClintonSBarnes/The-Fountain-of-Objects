using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class UserInputHandler
    {
        //accepting user inputs
        int _size { get; set; }
        string _userInput { get; set; }

        //user input getters and setters
        public void SetSize(int boardSize)
        {
            _size = boardSize;

        }
        public int GetSize()
        {
            return _size;
        }

        public void SetUserInput(string userInput)
        {
            _userInput = userInput;
        }
        public string GetUserInput()
        {
            return _userInput;
        }

        //player input validation tools
        public bool InputValidationCheckDifficulty(string input)
        {
            input = input.ToUpper();
            if (input == "E")
            {
                _size = 4;
                return true;
            }
            else if (input == "A")
            {
                _size = 6;
                return true;
            }
            else if (input == "X")
            {
                _size = 8;
                return true;
            }
            else
            {
                Console.WriteLine("That is not a valid selection. Please choose again.\nPress any key to continue.");
                return false;
            }

        }

        public (int, int) InputValidationCheckPlayerMove(int playerX, int playerY, string direction, int size)
        {
            bool looper = false;

            while (looper == false)
            {
                if (direction == "N" && playerX <= size && playerX >= 0)
                {
                    looper = true;
                    return (playerX++, playerY);
                }
                else if (direction == "S" && playerX <= size && playerX >= 0)
                {
                    looper = true;
                    return (playerX--, playerY);
                }
                else if (direction == "E" && playerY <= size && playerY >= 0)
                {
                    looper = true;
                    return (playerX, playerY--);
                }
                if (direction == "W" && playerY <= size && playerY >= 0)
                {
                    looper = true;
                    return (playerX, playerY++);
                }
                else
                {
                    Console.WriteLine("That was not a valid input. Please provide a valid input.");
                    Dialogue.PlayerMove();
                }

            }
            return (playerX, playerY);


        }
    }
}

enum RoomTrait { Pit, Maelstrom, Amaroks, Entry, None, }
enum FountainState { FountainOn, FountainOff }
