﻿namespace ZTP
{
    partial class MenuWindow
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
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.learningModelLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            this.BazaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.difficultyLabel.Location = new System.Drawing.Point(631, 76);
            this.difficultyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(480, 51);
            this.difficultyLabel.TabIndex = 0;
            this.difficultyLabel.Text = "WYBIERZ POZIOM:";
            // 
            // learningModelLabel
            // 
            this.learningModelLabel.AutoSize = true;
            this.learningModelLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.learningModelLabel.Location = new System.Drawing.Point(30, 76);
            this.learningModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.learningModelLabel.Name = "learningModelLabel";
            this.learningModelLabel.Size = new System.Drawing.Size(525, 51);
            this.learningModelLabel.TabIndex = 1;
            this.learningModelLabel.Text = "WYBIERZ PROGRAM:";
            this.learningModelLabel.Click += new System.EventHandler(this.learningModelLabel_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.startButton.Location = new System.Drawing.Point(80, 277);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(290, 64);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Test",
            "Learning"});
            this.comboBox1.Location = new System.Drawing.Point(68, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox2.Location = new System.Drawing.Point(688, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(390, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Englearn ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // endButton
            // 
            this.endButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.endButton.Location = new System.Drawing.Point(80, 463);
            this.endButton.Margin = new System.Windows.Forms.Padding(4);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(290, 64);
            this.endButton.TabIndex = 6;
            this.endButton.Text = "Wyjście";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // BazaButton
            // 
            this.BazaButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.BazaButton.Location = new System.Drawing.Point(80, 366);
            this.BazaButton.Margin = new System.Windows.Forms.Padding(4);
            this.BazaButton.Name = "BazaButton";
            this.BazaButton.Size = new System.Drawing.Size(290, 64);
            this.BazaButton.TabIndex = 7;
            this.BazaButton.Text = "BazaDanych";
            this.BazaButton.UseVisualStyleBackColor = true;
            this.BazaButton.Click += new System.EventHandler(this.BazaButton_Click);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BazaButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.learningModelLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuWindow";
            this.Text = "Englearn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label learningModelLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button BazaButton;
    }
}

