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
        static int player1 = 2;
        static int input = 0;
        bool inputCorrect;
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
            

            SetField();
            do
            {
                if (player1 == 2)
                {
                    player1 = 1;
                    ChangeField(player1,input);
                }
                else if (player1 == 2)
                {
                    ChangeField(player1, input);
                }
                  
           
            } while (true);
        }
        public static void SetField()
        {
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

    }

    
}
