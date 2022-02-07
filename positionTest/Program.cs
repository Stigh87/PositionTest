using System;
//public class KeyPressEventArgs : EventArgs;

namespace positionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            bool moving = true;

            Board board = new Board();

            board.DrawBoard(board.PosX, board.PosY, board.size);

            while (moving)
            {
                var KeyPress = Console.ReadKey().KeyChar;    
                board.Move(KeyPress);
                //board.PosY++   =   Direction / fjerne readkey/ eller legge den inn her?;
            }
        }
    }
}
