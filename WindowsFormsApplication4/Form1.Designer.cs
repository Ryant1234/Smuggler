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
            this.btnFill = new System.Windows.Forms.Button();
            this.btnApproach = new System.Windows.Forms.Button();
            this.btnSmuggle = new System.Windows.Forms.Button();
            this.btnCloak = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(82, 300);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 47);
            this.btnFill.TabIndex = 0;
            this.btnFill.Text = "Fill Backpack";
            this.btnFill.UseVisualStyleBackColor = true;
            // 
            // btnApproach
            // 
            this.btnApproach.Location = new System.Drawing.Point(163, 300);
            this.btnApproach.Name = "btnApproach";
            this.btnApproach.Size = new System.Drawing.Size(75, 47);
            this.btnApproach.TabIndex = 1;
            this.btnApproach.Text = "Approach Border";
            this.btnApproach.UseVisualStyleBackColor = true;
            // 
            // btnSmuggle
            // 
            this.btnSmuggle.Location = new System.Drawing.Point(244, 300);
            this.btnSmuggle.Name = "btnSmuggle";
            this.btnSmuggle.Size = new System.Drawing.Size(75, 47);
            this.btnSmuggle.TabIndex = 2;
            this.btnSmuggle.Text = "Smuggle";
            this.btnSmuggle.UseVisualStyleBackColor = true;
            // 
            // btnCloak
            // 
            this.btnCloak.Location = new System.Drawing.Point(325, 300);
            this.btnCloak.Name = "btnCloak";
            this.btnCloak.Size = new System.Drawing.Size(75, 47);
            this.btnCloak.TabIndex = 3;
            this.btnCloak.Text = "Use Cloaking Device";
            this.btnCloak.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(406, 300);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 47);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 239);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnCloak);
            this.Controls.Add(this.btnSmuggle);
            this.Controls.Add(this.btnApproach);
            this.Controls.Add(this.btnFill);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnApproach;
        private System.Windows.Forms.Button btnSmuggle;
        private System.Windows.Forms.Button btnCloak;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

