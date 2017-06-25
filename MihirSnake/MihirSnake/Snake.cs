using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihirSnake
{
    class Snake
    {
        public int squarex;
        public int squarey;
        public int height;
        public int width;

        enum Direction
        {
            Stopped,
            Up,
            Down,
            Left,
            Right
        }

        Direction direction;

        public Snake(int squarex, int squarey, int height, int width)
        {
            this.squarex = squarex;
            this.squarey = squarey;
            this.height = height;
            this.width = width;
            direction = Direction.Stopped;
        }
        public void Update()
        {
            if (direction == Direction.Up)
            {
                squarey = squarey - height;
            }

            if (direction == Direction.Down)
            {
                squarey = squarey + height;
            }

            if (direction == Direction.Left)
            {
                squarex = squarex - width;
            }

            if (direction == Direction.Right)
            {
                squarex = squarex + width;
            }
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(Brushes.Black, squarex, squarey, height, width);
        }

        public void SetDirection(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                direction = Direction.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                direction = Direction.Down;
            }

            if (e.KeyCode == Keys.Left)
            {
                direction = Direction.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                direction = Direction.Right;
            }
        }

        public bool Offscreen(int screenWidth, int screenHeight)
        {
            //to check if the snake is off screen

            if (height + squarey > screenHeight)
            {
                return true;
            }

            if (0 > squarey)
            {
                return true;
            }
            if (squarex + width > screenWidth)
            {
                return true;
            }
            if(0 > squarex)
            {
                return true;
            }
            

            return false;

        }


    }
}
