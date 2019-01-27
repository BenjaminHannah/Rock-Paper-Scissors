namespace RPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.lblOutput3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(44, 272);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(187, 94);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "ROCK!";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(547, 272);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(187, 94);
            this.btnScissors.TabIndex = 1;
            this.btnScissors.Text = "SCISSORS!";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(297, 272);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(187, 94);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "PAPER!";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(38, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(456, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Welcome to Rock, Paper, Scissors!";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(38, 74);
            this.lblInstructions.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(696, 160);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(38, 410);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 32);
            this.lblOutput.TabIndex = 5;
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Location = new System.Drawing.Point(38, 455);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(0, 32);
            this.lblOutput2.TabIndex = 6;
            // 
            // lblOutput3
            // 
            this.lblOutput3.AutoSize = true;
            this.lblOutput3.Location = new System.Drawing.Point(38, 500);
            this.lblOutput3.Name = "lblOutput3";
            this.lblOutput3.Size = new System.Drawing.Size(0, 32);
            this.lblOutput3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 560);
            this.Controls.Add(this.lblOutput3);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblOutput2;
        private System.Windows.Forms.Label lblOutput3;
    }
}

