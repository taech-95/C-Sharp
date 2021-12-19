using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        //Create the playfield
        static int turns = 0;
        static char[,] playfield =
        {
            {
                '1','2','3'
            },
            {
                '4','5','6'
            },
            {
                '7','8','9'
            }
        };

 

        static void Main(string[] args)
        {
            int player1 = 1;
            int input = 0;
            bool inputCorrect = true;
            do
            {
                
                if (player1 == 2)
                {
                    player1 = 1;
                    ChangeField(player1, input);
                }
                else if (player1 == 1)
                {
                    player1 = 2;
                    ChangeField(player1, input);
                }
                SetField();
                turns++;
                #region
                //check win condition
                char[] playerChars = { 'X', 'O' };
                foreach (char playerChar in playerChars)
                {
                    if (((playfield[0, 0] == playerChar) && (playfield[0, 1] == playerChar) && (playfield[0, 2] == playerChar))||
                        ((playfield[1, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar))||
                        ((playfield[2, 0] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))||
                        ((playfield[0, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 2] == playerChar))||
                        ((playfield[0, 2] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 0] == playerChar))||
                        ((playfield[0, 0] == playerChar) && (playfield[1, 0] == playerChar) && (playfield[2, 0] == playerChar))||
                        ((playfield[0, 1] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 1] == playerChar))||
                        ((playfield[0, 2] == playerChar) && (playfield[1, 2] == playerChar) && (playfield[2, 2] == playerChar)))
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("Player 2 has won!!! ^_^");
                        }
                        else if (playerChar == 'O')
                        {
                            Console.WriteLine("Player 1 has won!!! ^_^");
                        }
                        Console.WriteLine("Please press any kye to reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;

                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("It's a draw!!! Do you want to play again");
                        ResetField();
                        break;
                    }

                }

                #endregion
                #region
                //test is field is already taken
                do
                {
                    Console.WriteLine($"Player {player1}: Choose your field!");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Please enter a number between 1 and 9");
                    }
                    if (input==1 && playfield[0,0] == '1')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 2 && playfield[0, 1] == '2')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 3 && playfield[0, 2] == '3')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 4 && playfield[1, 0] == '4')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 5 && playfield[1, 1] == '5')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 6 && playfield[1, 2] == '6')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 7 && playfield[2, 0] == '7')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 8 && playfield[2, 1] == '8')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 9 && playfield[2, 2] == '9')
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorect input please use another field");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);

                #endregion
            } while (true);
        }
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("      |      |      ");
            Console.WriteLine("   {0}  |   {1}  |   {2}   ",playfield[0,0], playfield[0, 1], playfield[0, 2]);
            Console.WriteLine(" _____|______|______");
            Console.WriteLine("      |      |      ");
            Console.WriteLine("   {0}  |   {1}  |   {2}   ", playfield[1, 0], playfield[1, 1], playfield[1, 2]);
            Console.WriteLine(" _____|______|______");
            Console.WriteLine("      |      |      ");
            Console.WriteLine("   {0}  |   {1}  |   {2}   ", playfield[2, 0], playfield[2, 1], playfield[2, 2]);
            Console.WriteLine("      |      |      ");
        }

        public static void ChangeField(int player, int input)

        {
            char playerSign = ' ';
            if (player == 1)
            {
                playerSign = 'X';
            }
            else if (player == 2)
            {
                playerSign = 'O';
            }
            switch (input)
            {
                case 1:
                    playfield[0, 0] = playerSign;
                    break;
                case 2:
                    playfield[0, 1] = playerSign;
                    break;
                case 3:
                    playfield[0, 2] = playerSign;
                    break;
                case 4:
                    playfield[1, 0] = playerSign;
                    break;
                case 5:
                    playfield[1, 1] = playerSign;
                    break;
                case 6:
                    playfield[1, 2] = playerSign;
                    break;
                case 7:
                    playfield[2, 0] = playerSign;
                    break;
                case 8:
                    playfield[2, 1] = playerSign;
                    break;
                case 9:
                    playfield[2, 2] = playerSign;
                    break;
            }

        }

        public static void ResetField()
        {
            char[,] playfieldInitial =
            {
            {
                '1','2','3'
            },
            {
                '4','5','6'
            },
            {
                '7','8','9'
            }
             };
            playfield = playfieldInitial;
            SetField();
            turns = 0;
        }

    }

    
}
