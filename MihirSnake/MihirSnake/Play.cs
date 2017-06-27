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

        Snake head;
        Bitmap bitmap;
        Graphics gfx;

        public Play()
        {
            InitializeComponent();
            head = new Snake(20, 20, 20, 20);
            bitmap = new Bitmap(backgroundImage.Width, backgroundImage.Height);
            gfx = Graphics.FromImage(bitmap);
            SnakeMove_Tick(null, EventArgs.Empty);
        }

        private void SnakeMove_Tick(object sender, EventArgs e)
        {
            gfx.DrawImage(Properties.Resources.background_desert_design_elements_vector_585961, new Rectangle(0,0, ClientSize.Width, ClientSize.Height));

            head.Update();
            head.Draw(gfx);
            
            backgroundImage.Image = bitmap;

            if (head.Offscreen(ClientSize.Width, ClientSize.Height) == true)
            {
                SnakeMove.Stop();
                MessageBox.Show("You Lose!");
            }
        }

        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            head.SetDirection(e);
        }

   
    }
}
