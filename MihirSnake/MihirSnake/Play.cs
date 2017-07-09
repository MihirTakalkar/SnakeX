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

        //Snake (represents 1 peice of the snake)
        //Food
        //get a square on the screen and move it around 
        Random random = new Random();
        Snake head;
        Bitmap bitmap;
        Graphics gfx;
        Food food;

        public Play()
        {
            InitializeComponent();
            head = new Snake(20, 20, 20, 20);
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
            head.Update();

            if (head.Offscreen(ClientSize.Width, ClientSize.Height) == true)
            {
                SnakeMove.Stop();
                MessageBox.Show("You Lose!");
            }


            //draw
            head.Draw(gfx);
            food.Draw(gfx);

            backgroundImage.Image = bitmap;
        }

        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            head.SetDirection(e);
        }


    }
}
