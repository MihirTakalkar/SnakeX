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
        Snake snake;

        public Play()
        {
            InitializeComponent();
            snake = new Snake(20, 20, 20, 20);
            bitmap = new Bitmap(backgroundImage.Width, backgroundImage.Height);
            gfx = Graphics.FromImage(bitmap);
            food = new Food(0, 0, 20, 20);
            food.Respawn(ClientSize);
            SnakeMove.Enabled = true;
            //for (int i = 0; i < 10; i++)
            //{
            //    snake.Grow();
            //}
        }
        private void SnakeMove_Tick(object sender, EventArgs e)
        {
            //erase
            gfx.DrawImage(Properties.Resources.background_desert_design_elements_vector_585961, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));
            //update
            food.Update();
            snake.Update();
            if (snake.Head().hitbox.IntersectsWith(food.hitbox))
            {
                food.Respawn(ClientSize);
                snake.Grow();

            }
            if (snake.Head().Offscreen(ClientSize.Width, ClientSize.Height) == true || snake.c9llide() == true)
            {
                SnakeMove.Stop();
                MessageBox.Show("You Lose! Foool!");
                Reset();
            }
            //draw
            snake.Draw(gfx);
            food.Draw(gfx);

            backgroundImage.Image = bitmap;
        }
        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            snake.Head().SetDirection(e);
        }

        private void Reset()
        {
            this.Hide();
            GameOver form = new GameOver();
            form.ShowDialog();
            this.Show();

            snake.Reset();
            food.Respawn(ClientSize);
            SnakeMove.Start();
        }

        private void Play_Load(object sender, EventArgs e)
        {

        }
    }
}
