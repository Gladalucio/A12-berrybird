namespace BerryBird
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lbltxtBerry = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.lbltxtLevelselect = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltxtPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltxtBerry
            // 
            this.lbltxtBerry.AutoSize = true;
            this.lbltxtBerry.Font = new System.Drawing.Font("Kozuka Mincho Pro B", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltxtBerry.Location = new System.Drawing.Point(144, 3);
            this.lbltxtBerry.Name = "lbltxtBerry";
            this.lbltxtBerry.Size = new System.Drawing.Size(384, 103);
            this.lbltxtBerry.TabIndex = 1;
            this.lbltxtBerry.Text = "BerryBird";
            this.lbltxtBerry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbPicture);
            this.panel1.Controls.Add(this.lbltxtBerry);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 112);
            this.panel1.TabIndex = 2;
            // 
            // pbPicture
            // 
            this.pbPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPicture.BackgroundImage")));
            this.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPicture.Location = new System.Drawing.Point(3, 3);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(92, 103);
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.SkyBlue;
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Kozuka Mincho Pr6N M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(266, 237);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(107, 43);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "Freeplay";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.SkyBlue;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Kozuka Mincho Pr6N M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(27, 41);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(107, 43);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Level 1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.SkyBlue;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Kozuka Mincho Pr6N M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(140, 41);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(107, 43);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Level 2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.SkyBlue;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Kozuka Mincho Pr6N M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(253, 41);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(107, 43);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Level 3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.SkyBlue;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Kozuka Mincho Pr6N M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(366, 41);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(107, 43);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "Level 4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.SkyBlue;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Kozuka Mincho Pr6N M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(479, 41);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(107, 43);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "Level 5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // lbltxtLevelselect
            // 
            this.lbltxtLevelselect.AutoSize = true;
            this.lbltxtLevelselect.Font = new System.Drawing.Font("Kozuka Mincho Pro B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltxtLevelselect.Location = new System.Drawing.Point(249, 6);
            this.lbltxtLevelselect.Name = "lbltxtLevelselect";
            this.lbltxtLevelselect.Size = new System.Drawing.Size(116, 26);
            this.lbltxtLevelselect.TabIndex = 2;
            this.lbltxtLevelselect.Text = "Level Select";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbltxtLevelselect);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Location = new System.Drawing.Point(12, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 96);
            this.panel2.TabIndex = 9;
            // 
            // lbltxtPlayerName
            // 
            this.lbltxtPlayerName.AutoSize = true;
            this.lbltxtPlayerName.Font = new System.Drawing.Font("Kozuka Mincho Pro B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltxtPlayerName.Location = new System.Drawing.Point(230, 151);
            this.lbltxtPlayerName.Name = "lbltxtPlayerName";
            this.lbltxtPlayerName.Size = new System.Drawing.Size(176, 26);
            this.lbltxtPlayerName.TabIndex = 9;
            this.lbltxtPlayerName.Text = "Enter Player Name";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(222, 189);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(192, 20);
            this.txtPlayerName.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(637, 394);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lbltxtPlayerName);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lbltxtBerry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label lbltxtLevelselect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltxtPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
    }
}