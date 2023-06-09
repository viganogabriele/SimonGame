﻿namespace SimonGame
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picG = new System.Windows.Forms.PictureBox();
            this.picR = new System.Windows.Forms.PictureBox();
            this.picY = new System.Windows.Forms.PictureBox();
            this.picB = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSimon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            this.SuspendLayout();
            // 
            // picG
            // 
            this.picG.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picG.Location = new System.Drawing.Point(256, 124);
            this.picG.Name = "picG";
            this.picG.Size = new System.Drawing.Size(100, 50);
            this.picG.TabIndex = 0;
            this.picG.TabStop = false;
            this.picG.Click += new System.EventHandler(this.picG_Click);
            // 
            // picR
            // 
            this.picR.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picR.Location = new System.Drawing.Point(408, 124);
            this.picR.Name = "picR";
            this.picR.Size = new System.Drawing.Size(100, 50);
            this.picR.TabIndex = 1;
            this.picR.TabStop = false;
            this.picR.Click += new System.EventHandler(this.picR_Click);
            // 
            // picY
            // 
            this.picY.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picY.Location = new System.Drawing.Point(256, 215);
            this.picY.Name = "picY";
            this.picY.Size = new System.Drawing.Size(100, 50);
            this.picY.TabIndex = 2;
            this.picY.TabStop = false;
            this.picY.Click += new System.EventHandler(this.picY_Click);
            // 
            // picB
            // 
            this.picB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picB.Location = new System.Drawing.Point(408, 215);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(100, 50);
            this.picB.TabIndex = 3;
            this.picB.TabStop = false;
            this.picB.Click += new System.EventHandler(this.picB_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(329, 317);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 28);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Black;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(205, 154);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(372, 73);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(691, 398);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score: ";
            // 
            // lblSimon
            // 
            this.lblSimon.AutoSize = true;
            this.lblSimon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimon.ForeColor = System.Drawing.Color.Black;
            this.lblSimon.Location = new System.Drawing.Point(225, 22);
            this.lblSimon.Name = "lblSimon";
            this.lblSimon.Size = new System.Drawing.Size(314, 55);
            this.lblSimon.TabIndex = 8;
            this.lblSimon.Text = "Simon Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSimon);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picB);
            this.Controls.Add(this.picY);
            this.Controls.Add(this.picR);
            this.Controls.Add(this.picG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picG;
        private System.Windows.Forms.PictureBox picR;
        private System.Windows.Forms.PictureBox picY;
        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSimon;
    }
}

