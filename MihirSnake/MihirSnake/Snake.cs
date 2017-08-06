using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihirSnake
{
    class Snake
    {
        List<SnakePiece> snake;
        public Snake(int x, int y, int width, int height)
        {
            snake = new List<SnakePiece>();
            snake.Add(new SnakePiece(x, y, width, height));
        }

        public void Update()
        {
            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i].Update();

                snake[i].direction = snake[i - 1].direction;
                snake[i].squarex = snake[i - 1].squarex;
                snake[i].squarey = snake[i - 1].squarey;
                snake[i].hitbox = snake[i - 1].hitbox;
            }
            Head().Update();
        }

        public SnakePiece Head()
        {
            return snake[0];
        }

        public void Draw(Graphics gfx)
        {
            for (int i = 0; i < snake.Count; i++)
            {
                snake[i].Draw(gfx);
            }
        }

        public void Grow()
        {
            SnakePiece tail = snake[snake.Count - 1];
            if (tail.direction == SnakePiece.Direction.Up)
            {
                snake.Add(new SnakePiece(tail.squarex, tail.squarey + tail.height, tail.width, tail.height));
            }
            if (tail.direction == SnakePiece.Direction.Down)
            {
                snake.Add(new SnakePiece(tail.squarex, tail.squarey - tail.height, tail.width, tail.height));
            }
            if (tail.direction == SnakePiece.Direction.Right)
            {
                snake.Add(new SnakePiece(tail.squarex - tail.width, tail.squarey, tail.width, tail.height));
            }
            if (tail.direction == SnakePiece.Direction.Left)
            {
                snake.Add(new SnakePiece(tail.squarex + tail.width, tail.squarey, tail.width, tail.height));
            }
        }

        public bool c9llide()
        {
            for (int i = 1; i < snake.Count; i++)
            {
                if (Head().hitbox.IntersectsWith(snake[i].hitbox))
                {
                    return true;

                }
            }
            return false;
        }

        public void Reset()
        {
            SnakePiece head = Head();
            head.direction = SnakePiece.Direction.Stopped;
            head.squarex = 100;
            head.squarey = 100;
            snake.Clear();
            snake.Add(head);
        }

    }
}
