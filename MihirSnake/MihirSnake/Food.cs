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
        public int foodx;
        public int foody;
        public int height;
        public int width;
        public Rectangle hitbox;
        Random rand = new Random();
        public Food(int foodx, int foody, int height, int width)
        {
            this.foodx = foodx;
            this.foody = foody;
            this.height = height;
            this.width = width;
        }
        public void Update()
        {
            hitbox.X = foodx;
            hitbox.Y = foody;
            hitbox.Width = width;
            hitbox.Height = height;
        }
        public void Respawn(Size clientSize)
        {
         
            foodx = rand.Next(0, (clientSize.Width - width) / 20);
            foody = rand.Next(0, (clientSize.Height - height) /20);
            foodx *= 20;
            foody *= 20;
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(Brushes.Black, foodx, foody, height, width);
        }
    }
}
