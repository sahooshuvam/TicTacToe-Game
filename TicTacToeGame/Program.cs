using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {

        static char[,] playField = { { '1','2','3'},//Row 0
                                     { '4','5','6'},//Row 1
                                     { '7','8','9' } };//Row 2
        static void Main(string[] args)
        {

            bool isWin = GameStart();
            if (isWin == true)
            {
                Console.WriteLine("Enter 1 to restart the game");
                string userInputString = Console.ReadLine();
                int userInput = int.Parse(userInputString);
                if (userInput == 1)
                {
                    GameStart();
                }
            }
            Console.ReadLine();
        }

        private static bool GameStart()
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            do
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                    
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                DrawBoard();
                #region
                //To check the Winning Conditions
                char[] playerChar = { 'X', 'O' };
                bool isWin = false;
                foreach (var item in playerChar)
                {
                    if ((playField[0, 0] == item) && (playField[0, 1] == item) && (playField[0, 2] == item) ||
                        (playField[1, 0] == item) && (playField[1, 1] == item) && (playField[1, 2] == item) ||
                        (playField[2, 0] == item) && (playField[2, 1] == item) && (playField[2, 2] == item) ||
                        (playField[0, 0] == item) && (playField[1, 0] == item) && (playField[2, 0] == item) ||
                        (playField[0, 1] == item) && (playField[1, 1] == item) && (playField[2, 1] == item) ||
                        (playField[0, 2] == item) && (playField[1, 2] == item) && (playField[2, 2] == item) ||
                        (playField[0, 0] == item) && (playField[1, 1] == item) && (playField[2, 2] == item) ||
                        (playField[0, 2] == item) && (playField[1, 1] == item) && (playField[2, 0] == item))
                    {
                        if (item == 'X')
                        {
                            Console.WriteLine("Player 1 has Won");
                            isWin = true;
                            //return isWin;
                           
                        }
                        else if (item == 'O')
                        {
                            Console.WriteLine("Player 2 has Won");
                            isWin = true;
                            //return isWin;
                        }
                        break;

                    }
                }
                #endregion

                #region
                //This region is to Check that the field is occupied or not
                if (isWin == false)
                {
                    do
                    {
                        Console.WriteLine("\n Player {0}: Choose the Field", player);

                        try
                        {
                            input = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a number between 1 to 9");
                        }
                        if ((input == 1) && (playField[0, 0] == '1'))
                        {
                            inputCorrect = true;
                        }
                        else if ((input == 2) && (playField[0, 1] == '2'))
                        {
                            inputCorrect = true;
                        }
                        else if ((input == 3) && (playField[0, 2] == '3'))
                        {
                            inputCorrect = true;
                        }
                        else if ((input == 4) && (playField[1, 0] == '4'))
                        {
                            inputCorrect = true;
                        }
                        else if ((input == 5) && (playField[1, 1] == '5'))
                        {
                            inputCorrect = true;
                        }
                        else if ((input == 6) && (playField[1, 2] == '6'))
                        {
                            inputCorrect = true;
                        }
                        else if ((input == 7) && (playField[2, 0] == '7'))
                        {
                            inputCorrect = true;
                        }
                        else if ((input == 8) && (playField[2, 1] == '8'))
                        {
                            inputCorrect = true;
                        }
                        else if ((input == 9) && (playField[2, 2] == '9'))
                        {
                            inputCorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("Please Use another Field");
                            inputCorrect = false;
                        }
                    } while (!inputCorrect);
                    #endregion
                }
            } while (true);
        }
    

        private static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';


            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;

                case 2: playField[0, 1] = playerSign; break;

                case 3: playField[0, 2] = playerSign; break;

                case 4: playField[1, 0] = playerSign; break;

                case 5: playField[1, 1] = playerSign; break;

                case 6: playField[1, 2] = playerSign; break;

                case 7: playField[2, 0] = playerSign; break;

                case 8: playField[2, 1] = playerSign; break;

                case 9: playField[2, 2] = playerSign; break;

            }






        }

        private static void DrawBoard()
        {
            //This is a method to draw 3*3 Board
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("   |   |   ");
        }
    }
}