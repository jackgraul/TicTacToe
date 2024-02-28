namespace JGraulAssignment1
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tile1 = new PictureBox();
            tile2 = new PictureBox();
            tile3 = new PictureBox();
            tile4 = new PictureBox();
            tile5 = new PictureBox();
            tile6 = new PictureBox();
            tile7 = new PictureBox();
            tile8 = new PictureBox();
            tile9 = new PictureBox();
            lblTurn = new Label();
            ((System.ComponentModel.ISupportInitialize)tile1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tile2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tile3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tile4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tile5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tile6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tile7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tile8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tile9).BeginInit();
            SuspendLayout();
            // 
            // tile1
            // 
            tile1.BackColor = Color.Transparent;
            tile1.BorderStyle = BorderStyle.Fixed3D;
            tile1.Location = new Point(134, 71);
            tile1.Name = "tile1";
            tile1.Size = new Size(128, 125);
            tile1.SizeMode = PictureBoxSizeMode.StretchImage;
            tile1.TabIndex = 9;
            tile1.TabStop = false;
            tile1.Tag = "1";
            tile1.Click += TileClick;
            // 
            // tile2
            // 
            tile2.BackColor = Color.Transparent;
            tile2.BorderStyle = BorderStyle.Fixed3D;
            tile2.Location = new Point(268, 71);
            tile2.Name = "tile2";
            tile2.Size = new Size(128, 125);
            tile2.SizeMode = PictureBoxSizeMode.StretchImage;
            tile2.TabIndex = 10;
            tile2.TabStop = false;
            tile2.Tag = "2";
            tile2.Click += TileClick;
            // 
            // tile3
            // 
            tile3.BackColor = Color.Transparent;
            tile3.BorderStyle = BorderStyle.Fixed3D;
            tile3.Location = new Point(402, 71);
            tile3.Name = "tile3";
            tile3.Size = new Size(128, 125);
            tile3.SizeMode = PictureBoxSizeMode.StretchImage;
            tile3.TabIndex = 11;
            tile3.TabStop = false;
            tile3.Tag = "3";
            tile3.Click += TileClick;
            // 
            // tile4
            // 
            tile4.BackColor = Color.Transparent;
            tile4.BorderStyle = BorderStyle.Fixed3D;
            tile4.Location = new Point(134, 202);
            tile4.Name = "tile4";
            tile4.Size = new Size(128, 125);
            tile4.SizeMode = PictureBoxSizeMode.StretchImage;
            tile4.TabIndex = 12;
            tile4.TabStop = false;
            tile4.Tag = "4";
            tile4.Click += TileClick;
            // 
            // tile5
            // 
            tile5.BackColor = Color.Transparent;
            tile5.BorderStyle = BorderStyle.Fixed3D;
            tile5.Location = new Point(268, 202);
            tile5.Name = "tile5";
            tile5.Size = new Size(128, 125);
            tile5.SizeMode = PictureBoxSizeMode.StretchImage;
            tile5.TabIndex = 13;
            tile5.TabStop = false;
            tile5.Tag = "5";
            tile5.Click += TileClick;
            // 
            // tile6
            // 
            tile6.BackColor = Color.Transparent;
            tile6.BorderStyle = BorderStyle.Fixed3D;
            tile6.Location = new Point(402, 202);
            tile6.Name = "tile6";
            tile6.Size = new Size(128, 125);
            tile6.SizeMode = PictureBoxSizeMode.StretchImage;
            tile6.TabIndex = 14;
            tile6.TabStop = false;
            tile6.Tag = "6";
            tile6.Click += TileClick;
            // 
            // tile7
            // 
            tile7.BackColor = Color.Transparent;
            tile7.BorderStyle = BorderStyle.Fixed3D;
            tile7.Location = new Point(134, 333);
            tile7.Name = "tile7";
            tile7.Size = new Size(128, 125);
            tile7.SizeMode = PictureBoxSizeMode.StretchImage;
            tile7.TabIndex = 15;
            tile7.TabStop = false;
            tile7.Tag = "7";
            tile7.Click += TileClick;
            // 
            // tile8
            // 
            tile8.BackColor = Color.Transparent;
            tile8.BorderStyle = BorderStyle.Fixed3D;
            tile8.Location = new Point(268, 333);
            tile8.Name = "tile8";
            tile8.Size = new Size(128, 125);
            tile8.SizeMode = PictureBoxSizeMode.StretchImage;
            tile8.TabIndex = 16;
            tile8.TabStop = false;
            tile8.Tag = "8";
            tile8.Click += TileClick;
            // 
            // tile9
            // 
            tile9.BackColor = Color.Transparent;
            tile9.BorderStyle = BorderStyle.Fixed3D;
            tile9.Location = new Point(402, 333);
            tile9.Name = "tile9";
            tile9.Size = new Size(128, 125);
            tile9.SizeMode = PictureBoxSizeMode.StretchImage;
            tile9.TabIndex = 17;
            tile9.TabStop = false;
            tile9.Tag = "9";
            tile9.Click += TileClick;
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.BackColor = Color.Black;
            lblTurn.ForeColor = Color.Red;
            lblTurn.Location = new Point(299, 26);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(72, 25);
            lblTurn.TabIndex = 20;
            lblTurn.Text = "X's turn";
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(675, 516);
            Controls.Add(lblTurn);
            Controls.Add(tile9);
            Controls.Add(tile8);
            Controls.Add(tile7);
            Controls.Add(tile6);
            Controls.Add(tile5);
            Controls.Add(tile4);
            Controls.Add(tile3);
            Controls.Add(tile2);
            Controls.Add(tile1);
            Name = "TicTacToe";
            Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)tile1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tile2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tile3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tile4).EndInit();
            ((System.ComponentModel.ISupportInitialize)tile5).EndInit();
            ((System.ComponentModel.ISupportInitialize)tile6).EndInit();
            ((System.ComponentModel.ISupportInitialize)tile7).EndInit();
            ((System.ComponentModel.ISupportInitialize)tile8).EndInit();
            ((System.ComponentModel.ISupportInitialize)tile9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox tile1;
        private PictureBox tile2;
        private PictureBox tile3;
        private PictureBox tile4;
        private PictureBox tile5;
        private PictureBox tile6;
        private PictureBox tile7;
        private PictureBox tile8;
        private PictureBox tile9;
        private Button btnReplay;
        private Label lblTurn;
    }
}