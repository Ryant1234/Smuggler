namespace WindowsFormsApplication4
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
            this.btnApproach = new System.Windows.Forms.Button();
            this.btnSmuggle = new System.Windows.Forms.Button();
            this.btnCloak = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCloak = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApproach
            // 
            this.btnApproach.Location = new System.Drawing.Point(107, 300);
            this.btnApproach.Name = "btnApproach";
            this.btnApproach.Size = new System.Drawing.Size(75, 47);
            this.btnApproach.TabIndex = 1;
            this.btnApproach.Text = "Approach Border";
            this.btnApproach.UseVisualStyleBackColor = true;
            this.btnApproach.Click += new System.EventHandler(this.btnApproach_Click);
            // 
            // btnSmuggle
            // 
            this.btnSmuggle.Location = new System.Drawing.Point(205, 300);
            this.btnSmuggle.Name = "btnSmuggle";
            this.btnSmuggle.Size = new System.Drawing.Size(75, 47);
            this.btnSmuggle.TabIndex = 2;
            this.btnSmuggle.Text = "Smuggle";
            this.btnSmuggle.UseVisualStyleBackColor = true;
            this.btnSmuggle.Click += new System.EventHandler(this.btnSmuggle_Click);
            // 
            // btnCloak
            // 
            this.btnCloak.Location = new System.Drawing.Point(295, 300);
            this.btnCloak.Name = "btnCloak";
            this.btnCloak.Size = new System.Drawing.Size(75, 47);
            this.btnCloak.TabIndex = 3;
            this.btnCloak.Text = "Use Cloaking Device";
            this.btnCloak.UseVisualStyleBackColor = true;
            this.btnCloak.Click += new System.EventHandler(this.btnCloak_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(386, 300);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 47);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wins";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(491, 131);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(0, 13);
            this.lblWin.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Losses";
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Location = new System.Drawing.Point(491, 180);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(0, 13);
            this.lblLose.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 118);
            this.label2.MaximumSize = new System.Drawing.Size(100, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Uses of cloaking device left :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCloak
            // 
            this.lblCloak.AutoSize = true;
            this.lblCloak.Location = new System.Drawing.Point(76, 131);
            this.lblCloak.Name = "lblCloak";
            this.lblCloak.Size = new System.Drawing.Size(0, 13);
            this.lblCloak.TabIndex = 11;
            // 
            // pbMain
            // 
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMain.Image = global::WindowsFormsApplication4.Properties.Resources.SmuggleStart;
            this.pbMain.Location = new System.Drawing.Point(107, 2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(354, 251);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 5;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(550, 359);
            this.Controls.Add(this.lblCloak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnCloak);
            this.Controls.Add(this.btnSmuggle);
            this.Controls.Add(this.btnApproach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApproach;
        private System.Windows.Forms.Button btnSmuggle;
        private System.Windows.Forms.Button btnCloak;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCloak;
    }
}

