using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihirSnake
{
    class Food
    {
        public int  foodx;
        public int  foody;
        public int  height;
        public int  width;
        public Rectangle hitbox;

        public Food(int foodx, int foody, int height, int width)
        {
            this.foodx = foodx;
            this.foody = foody;
            this.height = height;
            this.width = width;
        }

        public void Update()
        {
            Random rand = new Random();
            hitbox.X = foodx;
            hitbox.Y = foody;
            hitbox.Width = width;
            hitbox.Height = height;
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(Brushes.Black, foodx, foody, height, width);
            gfx.DrawRectangle(Pens.Red, hitbox);
        }
    }
}
