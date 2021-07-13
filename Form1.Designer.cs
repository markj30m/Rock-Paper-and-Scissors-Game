namespace Rock_Paper_and_Scissors_Game
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
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.pbxAI = new System.Windows.Forms.PictureBox();
            this.countDowntimer = new System.Windows.Forms.Timer(this.components);
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblPlayername = new System.Windows.Forms.Label();
            this.lblAI = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAI)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPlayer
            // 
            this.pbxPlayer.Image = global::Rock_Paper_and_Scissors_Game.Properties.Resources.question;
            this.pbxPlayer.Location = new System.Drawing.Point(171, 63);
            this.pbxPlayer.Name = "pbxPlayer";
            this.pbxPlayer.Size = new System.Drawing.Size(130, 130);
            this.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayer.TabIndex = 0;
            this.pbxPlayer.TabStop = false;
            // 
            // pbxAI
            // 
            this.pbxAI.Image = global::Rock_Paper_and_Scissors_Game.Properties.Resources.question;
            this.pbxAI.Location = new System.Drawing.Point(592, 63);
            this.pbxAI.Name = "pbxAI";
            this.pbxAI.Size = new System.Drawing.Size(130, 130);
            this.pbxAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAI.TabIndex = 1;
            this.pbxAI.TabStop = false;
            // 
            // countDowntimer
            // 
            this.countDowntimer.Interval = 1000;
            this.countDowntimer.Tick += new System.EventHandler(this.countDowntimerEvent);
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(41, 77);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 2;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(41, 123);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 3;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.Location = new System.Drawing.Point(41, 166);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(75, 23);
            this.btnScissor.TabIndex = 4;
            this.btnScissor.Text = "Scissor";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(746, 260);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Restart";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblPlayername
            // 
            this.lblPlayername.AutoSize = true;
            this.lblPlayername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayername.Location = new System.Drawing.Point(178, 32);
            this.lblPlayername.Name = "lblPlayername";
            this.lblPlayername.Size = new System.Drawing.Size(123, 24);
            this.lblPlayername.TabIndex = 6;
            this.lblPlayername.Text = "PlayerName";
            this.lblPlayername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAI
            // 
            this.lblAI.AutoSize = true;
            this.lblAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAI.Location = new System.Drawing.Point(644, 32);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(29, 24);
            this.lblAI.TabIndex = 7;
            this.lblAI.Text = "AI";
            this.lblAI.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(405, 76);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(97, 24);
            this.lblscore.TabIndex = 8;
            this.lblscore.Text = "Win/Lose";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(432, 141);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(21, 24);
            this.lblCountdown.TabIndex = 9;
            this.lblCountdown.Text = "5";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.Location = new System.Drawing.Point(405, 201);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(82, 24);
            this.lblRounds.TabIndex = 10;
            this.lblRounds.Text = "Rounds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 311);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblAI);
            this.Controls.Add(this.lblPlayername);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.pbxAI);
            this.Controls.Add(this.pbxPlayer);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.PictureBox pbxAI;
        private System.Windows.Forms.Timer countDowntimer;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblPlayername;
        private System.Windows.Forms.Label lblAI;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Label lblRounds;
    }
}

