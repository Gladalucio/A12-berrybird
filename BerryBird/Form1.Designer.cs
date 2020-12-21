namespace BerryBird
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
            this.pbBottom = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb0 = new System.Windows.Forms.PictureBox();
            this.lbltxtScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblLast = new System.Windows.Forms.Label();
            this.lbltxtLast = new System.Windows.Forms.Label();
            this.lblBest = new System.Windows.Forms.Label();
            this.lbltxtBest = new System.Windows.Forms.Label();
            this.lblPlayPause = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayerMAIN = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbPlane = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBottom
            // 
            this.pbBottom.BackColor = System.Drawing.Color.Transparent;
            this.pbBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBottom.BackgroundImage")));
            this.pbBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBottom.Location = new System.Drawing.Point(-3, -34);
            this.pbBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBottom.Name = "pbBottom";
            this.pbBottom.Size = new System.Drawing.Size(852, 474);
            this.pbBottom.TabIndex = 0;
            this.pbBottom.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Gray;
            this.pb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb1.BackgroundImage")));
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(340, 0);
            this.pb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(60, 162);
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(173, 183);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(43, 50);
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Gray;
            this.pb2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb2.BackgroundImage")));
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(474, 216);
            this.pb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(60, 224);
            this.pb2.TabIndex = 5;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Gray;
            this.pb3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb3.BackgroundImage")));
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(562, 0);
            this.pb3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(60, 95);
            this.pb3.TabIndex = 4;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb4.BackColor = System.Drawing.Color.Gray;
            this.pb4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb4.BackgroundImage")));
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.Location = new System.Drawing.Point(648, 295);
            this.pb4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(60, 144);
            this.pb4.TabIndex = 7;
            this.pb4.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Gray;
            this.pb5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb5.BackgroundImage")));
            this.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb5.Location = new System.Drawing.Point(737, 0);
            this.pb5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(60, 181);
            this.pb5.TabIndex = 6;
            this.pb5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb0
            // 
            this.pb0.BackColor = System.Drawing.Color.Gray;
            this.pb0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb0.BackgroundImage")));
            this.pb0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb0.Location = new System.Drawing.Point(275, 268);
            this.pb0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(60, 171);
            this.pb0.TabIndex = 10;
            this.pb0.TabStop = false;
            // 
            // lbltxtScore
            // 
            this.lbltxtScore.AutoSize = true;
            this.lbltxtScore.Font = new System.Drawing.Font("Kozuka Mincho Pro M", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltxtScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltxtScore.Location = new System.Drawing.Point(-4, 0);
            this.lbltxtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtScore.Name = "lbltxtScore";
            this.lbltxtScore.Size = new System.Drawing.Size(113, 41);
            this.lbltxtScore.TabIndex = 11;
            this.lbltxtScore.Text = "SCORE";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Kozuka Mincho Pro M", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(-3, 32);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(42, 46);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Red;
            this.lblWelcome.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(843, 119);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1035, 231);
            this.lblWelcome.TabIndex = 13;
            this.lblWelcome.Text = "WELCOME  ";
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Kozuka Mincho Pro M", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLast.Location = new System.Drawing.Point(-1, 101);
            this.lblLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(42, 46);
            this.lblLast.TabIndex = 15;
            this.lblLast.Text = "0";
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbltxtLast
            // 
            this.lbltxtLast.AutoSize = true;
            this.lbltxtLast.Font = new System.Drawing.Font("Kozuka Mincho Pro M", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltxtLast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltxtLast.Location = new System.Drawing.Point(0, 69);
            this.lbltxtLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtLast.Name = "lbltxtLast";
            this.lbltxtLast.Size = new System.Drawing.Size(91, 41);
            this.lbltxtLast.TabIndex = 14;
            this.lbltxtLast.Text = "LAST";
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Font = new System.Drawing.Font("Kozuka Mincho Pro M", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBest.Location = new System.Drawing.Point(-1, 170);
            this.lblBest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(42, 46);
            this.lblBest.TabIndex = 17;
            this.lblBest.Text = "0";
            this.lblBest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbltxtBest
            // 
            this.lbltxtBest.AutoSize = true;
            this.lbltxtBest.Font = new System.Drawing.Font("Kozuka Mincho Pro M", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtBest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltxtBest.Location = new System.Drawing.Point(0, 138);
            this.lbltxtBest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtBest.Name = "lbltxtBest";
            this.lbltxtBest.Size = new System.Drawing.Size(90, 41);
            this.lbltxtBest.TabIndex = 16;
            this.lbltxtBest.Text = "BEST";
            // 
            // lblPlayPause
            // 
            this.lblPlayPause.AutoSize = true;
            this.lblPlayPause.BackColor = System.Drawing.Color.Black;
            this.lblPlayPause.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPlayPause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayPause.Location = new System.Drawing.Point(0, 393);
            this.lblPlayPause.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayPause.Name = "lblPlayPause";
            this.lblPlayPause.Size = new System.Drawing.Size(112, 42);
            this.lblPlayPause.TabIndex = 18;
            this.lblPlayPause.Text = "START";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(419, 26);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 19;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Kozuka Mincho Pro M", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerName.Location = new System.Drawing.Point(128, 393);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(0, 41);
            this.lblPlayerName.TabIndex = 20;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Kozuka Mincho Pro M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLevel.Location = new System.Drawing.Point(-3, 352);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(92, 33);
            this.lblLevel.TabIndex = 21;
            this.lblLevel.Text = "SCORE";
            // 
            // axWindowsMediaPlayerMAIN
            // 
            this.axWindowsMediaPlayerMAIN.Enabled = true;
            this.axWindowsMediaPlayerMAIN.Location = new System.Drawing.Point(419, 66);
            this.axWindowsMediaPlayerMAIN.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayerMAIN.Name = "axWindowsMediaPlayerMAIN";
            this.axWindowsMediaPlayerMAIN.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMAIN.OcxState")));
            this.axWindowsMediaPlayerMAIN.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayerMAIN.TabIndex = 22;
            this.axWindowsMediaPlayerMAIN.Visible = false;
            // 
            // pbPlane
            // 
            this.pbPlane.BackColor = System.Drawing.Color.Transparent;
            this.pbPlane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPlane.BackgroundImage")));
            this.pbPlane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlane.Location = new System.Drawing.Point(840, 186);
            this.pbPlane.Name = "pbPlane";
            this.pbPlane.Size = new System.Drawing.Size(224, 142);
            this.pbPlane.TabIndex = 23;
            this.pbPlane.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 433);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pbPlane);
            this.Controls.Add(this.axWindowsMediaPlayerMAIN);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblPlayPause);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.lbltxtBest);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lbltxtLast);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lbltxtScore);
            this.Controls.Add(this.pb0);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pbBottom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Berry\'s Battle";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Movement);
            ((System.ComponentModel.ISupportInitialize)(this.pbBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBottom;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb0;
        private System.Windows.Forms.Label lbltxtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lbltxtLast;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Label lbltxtBest;
        private System.Windows.Forms.Label lblPlayPause;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblLevel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMAIN;
        private System.Windows.Forms.PictureBox pbPlane;
    }
}

