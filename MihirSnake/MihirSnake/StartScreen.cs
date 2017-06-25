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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            
        }

        private void Move_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i > 5; i++)
            {
                Design1.Value += 20;
                Design2.Value += 20;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Hide();
            Play playForm = new Play();
            playForm.ShowDialog();
        }
    }
}
