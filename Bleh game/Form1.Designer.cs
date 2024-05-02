namespace Bleh_game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.road1 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.road2 = new System.Windows.Forms.PictureBox();
            this.road3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.road2);
            this.panel1.Controls.Add(this.road3);
            this.panel1.Controls.Add(this.road1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 477);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AI1
            // 
            this.AI1.Image = global::Bleh_game.Properties.Resources.car;
            this.AI1.Location = new System.Drawing.Point(55, 131);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(158, 121);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 5;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carvasak";
            // 
            // AI2
            // 
            this.AI2.Image = global::Bleh_game.Properties.Resources.car;
            this.AI2.Location = new System.Drawing.Point(371, 131);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(152, 121);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 4;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carparem";
            // 
            // player
            // 
            this.player.Image = global::Bleh_game.Properties.Resources.you;
            this.player.InitialImage = global::Bleh_game.Properties.Resources.you;
            this.player.Location = new System.Drawing.Point(227, 409);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 65);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Nachlieli CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cars passed : 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // road1
            // 
            this.road1.Image = global::Bleh_game.Properties.Resources._360_F_111474023_0BQqfF2GEkeo8Ou3dkAk1eWie6KQ1AKr;
            this.road1.InitialImage = global::Bleh_game.Properties.Resources._360_F_111474023_0BQqfF2GEkeo8Ou3dkAk1eWie6KQ1AKr;
            this.road1.Location = new System.Drawing.Point(0, -23);
            this.road1.Name = "road1";
            this.road1.Size = new System.Drawing.Size(555, 500);
            this.road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road1.TabIndex = 2;
            this.road1.TabStop = false;
            this.road1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Nachlieli CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.start.Location = new System.Drawing.Point(206, 495);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(155, 53);
            this.start.TabIndex = 0;
            this.start.Text = "Let me in!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // road2
            // 
            this.road2.Image = global::Bleh_game.Properties.Resources._360_F_111474023_0BQqfF2GEkeo8Ou3dkAk1eWie6KQ1AKr;
            this.road2.InitialImage = global::Bleh_game.Properties.Resources._360_F_111474023_0BQqfF2GEkeo8Ou3dkAk1eWie6KQ1AKr;
            this.road2.Location = new System.Drawing.Point(0, -500);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(555, 500);
            this.road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road2.TabIndex = 6;
            this.road2.TabStop = false;
            this.road2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // road3
            // 
            this.road3.Image = global::Bleh_game.Properties.Resources._360_F_111474023_0BQqfF2GEkeo8Ou3dkAk1eWie6KQ1AKr;
            this.road3.InitialImage = global::Bleh_game.Properties.Resources._360_F_111474023_0BQqfF2GEkeo8Ou3dkAk1eWie6KQ1AKr;
            this.road3.Location = new System.Drawing.Point(0, -1000);
            this.road3.Name = "road3";
            this.road3.Size = new System.Drawing.Size(555, 500);
            this.road3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road3.TabIndex = 7;
            this.road3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 854);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nachlieli CLM", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "blehhhh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox road1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox road2;
        private System.Windows.Forms.PictureBox road3;
    }
}

