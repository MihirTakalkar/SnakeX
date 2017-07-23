using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihirSnake.Resources
{
    //These are the pieces of your snake!!!!
    //They should be able to move and have all the cool snake stuff
    //They should go into a list that snake holds
    class SnakePiece
    {
        List<Snake> dew;
        public SnakePiece(int x, int y, int width, int height)
        {
            dew = new List<Snake>();
            dew.Add(new Snake(x, y, width, height));
        }



        public void AddSnakePiece()
        {
            //add a new snake to your list dew
            //it's location is determined by the location and direction of the last piece in the list
            //what does this mean?
            //if the last piece in the snakepieces list is moving up, then the new snake piece should spawn under this one
            

        }

    }
}
