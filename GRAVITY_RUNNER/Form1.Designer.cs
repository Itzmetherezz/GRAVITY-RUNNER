namespace GRAVITY_RUNNER
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            player = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblScore = new Label();
            lblHighScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            GAMEEND = new Panel();
            lblEndScore = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            GAMEEND.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.platform_tilesblue;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.platform_tilesblue;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.run_down0;
            resources.ApplyResources(player, "player");
            player.Name = "player";
            player.TabStop = false;
            
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.box;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "obstacle";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.box;
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "obstacle";
            // 
            // lblScore
            // 
            resources.ApplyResources(lblScore, "lblScore");
            lblScore.BackColor = Color.Transparent;
            lblScore.ForeColor = Color.White;
            lblScore.Name = "lblScore";
            // 
            // lblHighScore
            // 
            resources.ApplyResources(lblHighScore, "lblHighScore");
            lblHighScore.BackColor = Color.Transparent;
            lblHighScore.ForeColor = Color.White;
            lblHighScore.Name = "lblHighScore";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimerEvent;
            // 
            // GAMEEND
            // 
            GAMEEND.BackColor = Color.Black;
            GAMEEND.Controls.Add(lblEndScore);
            GAMEEND.Controls.Add(label2);
            GAMEEND.Controls.Add(label1);
            resources.ApplyResources(GAMEEND, "GAMEEND");
            GAMEEND.Name = "GAMEEND";
            // 
            // lblEndScore
            // 
            resources.ApplyResources(lblEndScore, "lblEndScore");
            lblEndScore.ForeColor = Color.DeepPink;
            lblEndScore.Name = "lblEndScore";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.HotPink;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Red;
            label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_still;
            Controls.Add(GAMEEND);
            Controls.Add(lblHighScore);
            Controls.Add(lblScore);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(player);
            DoubleBuffered = true;
            Name = "Form1";
           
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            GAMEEND.ResumeLayout(false);
            GAMEEND.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox player;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblScore;
        private Label lblHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private Panel GAMEEND;
        private Label label1;
        private Label lblEndScore;
        private Label label2;
    }
}
