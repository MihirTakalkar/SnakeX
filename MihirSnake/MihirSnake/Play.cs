using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihirSnake
{
    public partial class Play : Form
    {
        Random random = new Random();
        //SnakePiece head;
        Bitmap bitmap;
        Graphics gfx;
        Food food;
        Snake dew;
        public Play()
        {
            InitializeComponent();
            dew = new Snake(20, 20, 20, 20);
            bitmap = new Bitmap(backgroundImage.Width, backgroundImage.Height);
            gfx = Graphics.FromImage(bitmap);
            food = new Food(random.Next(0, ClientSize.Width - 20), random.Next(0, ClientSize.Height - 20), 20, 20);
            SnakeMove.Enabled = true;
        }
        private void SnakeMove_Tick(object sender, EventArgs e)
        {
            //erase
            gfx.DrawImage(Properties.Resources.background_desert_design_elements_vector_585961, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));
            //update
            food.Update();
            dew.Update();
            if (dew.Head().hitbox.IntersectsWith(food.hitbox))
            {
                food.Respawn(ClientSize);
                dew.Grow();
                
            }
            if (dew.Head().Offscreen(ClientSize.Width, ClientSize.Height) == true)
            {
                SnakeMove.Stop();
                MessageBox.Show("You Lose!");
            }
            //draw
            dew.Draw(gfx);
            food.Draw(gfx);

            backgroundImage.Image = bitmap;
        }
        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            dew.Head().SetDirection(e);
        }
    }
}
