namespace MihirSnake
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Classic = new System.Windows.Forms.Label();
            this.Fun = new System.Windows.Forms.Label();
            this.Upgraded = new System.Windows.Forms.Label();
            this.Food = new System.Windows.Forms.Label();
            this.Eat = new System.Windows.Forms.Label();
            this.The = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Design1 = new System.Windows.Forms.ProgressBar();
            this.Design2 = new System.Windows.Forms.ProgressBar();
            this.Move = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Classic
            // 
            this.Classic.AutoSize = true;
            this.Classic.BackColor = System.Drawing.Color.Aqua;
            this.Classic.Font = new System.Drawing.Font("Pericles", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Classic.Location = new System.Drawing.Point(12, 9);
            this.Classic.Name = "Classic";
            this.Classic.Size = new System.Drawing.Size(78, 21);
            this.Classic.TabIndex = 2;
            this.Classic.Text = "Classic!";
            // 
            // Fun
            // 
            this.Fun.AutoSize = true;
            this.Fun.BackColor = System.Drawing.Color.Aqua;
            this.Fun.Font = new System.Drawing.Font("Pericles", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Fun.Location = new System.Drawing.Point(107, 19);
            this.Fun.Name = "Fun";
            this.Fun.Size = new System.Drawing.Size(51, 21);
            this.Fun.TabIndex = 3;
            this.Fun.Text = "Fun!";
            // 
            // Upgraded
            // 
            this.Upgraded.AutoSize = true;
            this.Upgraded.BackColor = System.Drawing.Color.Aqua;
            this.Upgraded.Font = new System.Drawing.Font("Pericles", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upgraded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Upgraded.Location = new System.Drawing.Point(171, 9);
            this.Upgraded.Name = "Upgraded";
            this.Upgraded.Size = new System.Drawing.Size(101, 21);
            this.Upgraded.TabIndex = 4;
            this.Upgraded.Text = "Upgraded!";
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.BackColor = System.Drawing.Color.Red;
            this.Food.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food.ForeColor = System.Drawing.Color.Lime;
            this.Food.Location = new System.Drawing.Point(169, 144);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(60, 24);
            this.Food.TabIndex = 5;
            this.Food.Text = "Food!";
            // 
            // Eat
            // 
            this.Eat.AutoSize = true;
            this.Eat.BackColor = System.Drawing.Color.Red;
            this.Eat.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eat.ForeColor = System.Drawing.Color.Lime;
            this.Eat.Location = new System.Drawing.Point(65, 144);
            this.Eat.Name = "Eat";
            this.Eat.Size = new System.Drawing.Size(39, 24);
            this.Eat.TabIndex = 6;
            this.Eat.Text = "Eat";
            // 
            // The
            // 
            this.The.AutoSize = true;
            this.The.BackColor = System.Drawing.Color.Red;
            this.The.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.The.ForeColor = System.Drawing.Color.Lime;
            this.The.Location = new System.Drawing.Point(116, 144);
            this.The.Name = "The";
            this.The.Size = new System.Drawing.Size(42, 24);
            this.The.TabIndex = 7;
            this.The.Text = "The";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PlayButton.BackgroundImage = global::MihirSnake.Properties.Resources._6;
            this.PlayButton.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.Blue;
            this.PlayButton.Location = new System.Drawing.Point(68, 218);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(153, 36);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play!";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MihirSnake.Properties.Resources.unnamed__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Design1
            // 
            this.Design1.Location = new System.Drawing.Point(245, 144);
            this.Design1.Name = "Design1";
            this.Design1.Size = new System.Drawing.Size(28, 105);
            this.Design1.TabIndex = 8;
            this.Design1.Value = 100;
            // 
            // Design2
            // 
            this.Design2.Location = new System.Drawing.Point(16, 143);
            this.Design2.Name = "Design2";
            this.Design2.Size = new System.Drawing.Size(28, 105);
            this.Design2.TabIndex = 9;
            this.Design2.Value = 100;
            // 
            // Move
            // 
            this.Move.Tick += new System.EventHandler(this.Move_Tick);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Design2);
            this.Controls.Add(this.Design1);
            this.Controls.Add(this.The);
            this.Controls.Add(this.Eat);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Upgraded);
            this.Controls.Add(this.Fun);
            this.Controls.Add(this.Classic);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label Classic;
        private System.Windows.Forms.Label Fun;
        private System.Windows.Forms.Label Upgraded;
        private System.Windows.Forms.Label Food;
        private System.Windows.Forms.Label Eat;
        private System.Windows.Forms.Label The;
        private System.Windows.Forms.ProgressBar Design1;
        private System.Windows.Forms.ProgressBar Design2;
        private System.Windows.Forms.Timer Move;
    }
}