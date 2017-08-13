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
        public int Foodx;
        public int Foody;
        public int height;
        public int width;
        public Rectangle hitbox;
        Random rand = new Random();
        public Food(int foodx, int foody, int height, int width)
        {
            this.Foodx = foodx;
            this.Foody = foody;
            this.height = height;
            this.width = width;
        }
        public void Update()
        {
            hitbox.X = Foodx;
            hitbox.Y = Foody;
            hitbox.Width = width;
            hitbox.Height = height;
        }
        public void Respawn(Size clientSize)
        {
         
            Foodx = rand.Next(0, (clientSize.Width - width) / 20);
            Foody = rand.Next(0, (clientSize.Height - height) /20);
            Foodx *= 20;
            Foody *= 20;
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(Brushes.Black, Foodx, Foody, height, width);
        }
    }
}
