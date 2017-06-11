using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihirSnake
{
    class Snake
    {
        public int squarex;
        public int squarey;
        public int height;
        public int width;
        public int speed;

        enum Direction
        {
            Stopped,
            Up,
            Down,
            Left,
            Right
        }

        Direction direction;

        public Snake(int squarex, int squarey, int height, int width, int speed)
        {
            this.squarex = squarex;
            this.squarey = squarey;
            this.height = height;
            this.width = width;
            this.speed = speed;
        }
    }
}
