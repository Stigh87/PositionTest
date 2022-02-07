using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positionTest
{
    public class Bomb
    {
        public string bomb = "X";
        public int bombX;
        public int bombY;


        public Bomb()
        {
            Random rnd = new Random();
            int Y = rnd.Next(1, 9); 
            bombX = Y;
            int X = rnd.Next(1, 9); 
            bombY = X;
        }
        
    }
}
