using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihirSnake
{
    //These are the pieces of your snake!!!!
    //They should be able to move and have all the cool snake stuff
    //They should go into a list that snake holds
    class Snake
    {
        List<SnakePiece> dew;
        public Snake(int x, int y, int width, int height)
        {
            dew = new List<SnakePiece>();
            dew.Add(new SnakePiece(x, y, width, height));
        }
        public void AddSnakePiece()
        {
            //add a new snake to your list dew
            //it's location is determined by the location and direction of the last piece in the list
            //what does this mean?
            //if the last piece in the snakepieces list is moving up, then the new snake piece should spawn under this one
            

        }

        public void Update()
        {
            Head().Update();
            for (int i = dew.Count - 1; i > 0; i--)
            {
                dew[i].Update();
                
                dew[i].direction = dew[i - 1].direction;
                dew[i].squarex = dew[i - 1].squarex;
                dew[i].squarey = dew[i - 1].squarey;
                dew[i].hitbox = dew[i - 1].hitbox;
                
                

            }
        }

        public SnakePiece Head()
        {
            return dew[0];
        }

        public void Draw(Graphics gfx)
        {
            for (int i = 0; i < dew.Count; i++)
            {
                dew[i].Draw(gfx);
            }
        }

        public void Grow()
        {
            SnakePiece tail = dew[dew.Count - 1];
            if(tail.direction == SnakePiece.Direction.Up)
            {
                dew.Add(new SnakePiece(tail.squarex, tail.squarey + tail.width, tail.width, tail.height));
            }
            if(tail.direction == SnakePiece.Direction.Down)
            {
                dew.Add(new SnakePiece(tail.squarex, tail.squarey - tail.height, tail.width, tail.height));
            }
            if(tail.direction == SnakePiece.Direction.Right)
            {
                dew.Add(new SnakePiece(tail.squarex - tail.width, tail.squarey, tail.width, tail.height));
            }
            if (tail.direction == SnakePiece.Direction.Right)
            {
                dew.Add(new SnakePiece(tail.squarex + tail.width, tail.squarey, tail.width, tail.height));
            }
        }


    }
}
