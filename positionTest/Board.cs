using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positionTest
{
    public class Board
    {
        public int PosX = 0;
        public int PosY = 0;
        public int size = 10;
        public bool activeBomb = true;
        public int points = 0;
        Bomb bomb = new Bomb();

        public void DrawBoard(int posX, int posY, int size)
        {
            for (int y = size; y >= 0; y--)
            {
                for (int x = 0; x <= size; x++)
                { 
                    if (activeBomb)
                    {
                        if (bomb.bombX == x && bomb.bombY == y)
                        {
                            Console.Write("X");
                        }   
                    }
                    if (PosX == x && PosY == y)
                    {
                        Console.Write("O");
                    }
                    else Console.Write("  ");
                }
                Console.WriteLine(" ");
            }
            if (posY == bomb.bombY && posX == bomb.bombX)
            {
                activeBomb = false;
                points++;
                bomb = new Bomb();
            }
            Console.WriteLine("PosisjonX: " + PosX);
            Console.WriteLine("PosisjonY: " + PosY);
            Console.WriteLine(" ");
            Console.WriteLine("Poeng: " + points);
        }

        public void Move(char KeyPress)
        {
            Console.WriteLine();
            if (KeyPress == 'w' && PosY != size) PosY++;
            if (KeyPress == 'a' && PosX != 0) PosX--;
            if (KeyPress == 's' && PosY != 0) PosY--;
            if (KeyPress == 'd' && PosX != size) PosX++;
            
            Console.Clear();
            if (!activeBomb) activeBomb = true;
            DrawBoard(PosX, PosY, size);
        }
    }
}
