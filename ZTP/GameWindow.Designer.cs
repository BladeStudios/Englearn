namespace ZTP
{
    partial class GameWindow
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
            this.answerAButton = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.answerBButton = new System.Windows.Forms.Button();
            this.answerCButton = new System.Windows.Forms.Button();
            this.answerDButton = new System.Windows.Forms.Button();
            this.answerEButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerAButton
            // 
            this.answerAButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.answerAButton.Location = new System.Drawing.Point(156, 162);
            this.answerAButton.Name = "answerAButton";
            this.answerAButton.Size = new System.Drawing.Size(473, 41);
            this.answerAButton.TabIndex = 3;
            this.answerAButton.Text = "odpowiedźA";
            this.answerAButton.UseVisualStyleBackColor = true;
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.modeLabel.ForeColor = System.Drawing.Color.Black;
            this.modeLabel.Location = new System.Drawing.Point(12, 18);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(152, 18);
            this.modeLabel.TabIndex = 6;
            this.modeLabel.Text = "Tryb programu: ";
            this.modeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.modeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.levelLabel.ForeColor = System.Drawing.Color.Black;
            this.levelLabel.Location = new System.Drawing.Point(12, 45);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(169, 18);
            this.levelLabel.TabIndex = 7;
            this.levelLabel.Text = "Poziom trudności: ";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.translationLabel.ForeColor = System.Drawing.Color.Black;
            this.translationLabel.Location = new System.Drawing.Point(12, 72);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(131, 18);
            this.translationLabel.TabIndex = 8;
            this.translationLabel.Text = "Tłumaczenie: ";
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(325, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "SŁOWO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // answerBButton
            // 
            this.answerBButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.answerBButton.Location = new System.Drawing.Point(156, 209);
            this.answerBButton.Name = "answerBButton";
            this.answerBButton.Size = new System.Drawing.Size(473, 41);
            this.answerBButton.TabIndex = 10;
            this.answerBButton.Text = "odpowiedźB";
            this.answerBButton.UseVisualStyleBackColor = true;
            // 
            // answerCButton
            // 
            this.answerCButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.answerCButton.Location = new System.Drawing.Point(156, 256);
            this.answerCButton.Name = "answerCButton";
            this.answerCButton.Size = new System.Drawing.Size(473, 41);
            this.answerCButton.TabIndex = 11;
            this.answerCButton.Text = "odpowiedźC";
            this.answerCButton.UseVisualStyleBackColor = true;
            // 
            // answerDButton
            // 
            this.answerDButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.answerDButton.Location = new System.Drawing.Point(156, 303);
            this.answerDButton.Name = "answerDButton";
            this.answerDButton.Size = new System.Drawing.Size(473, 41);
            this.answerDButton.TabIndex = 12;
            this.answerDButton.Text = "odpowiedźD";
            this.answerDButton.UseVisualStyleBackColor = true;
            // 
            // answerEButton
            // 
            this.answerEButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.answerEButton.Location = new System.Drawing.Point(156, 350);
            this.answerEButton.Name = "answerEButton";
            this.answerEButton.Size = new System.Drawing.Size(473, 41);
            this.answerEButton.TabIndex = 13;
            this.answerEButton.Text = "odpowiedźE";
            this.answerEButton.UseVisualStyleBackColor = true;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerEButton);
            this.Controls.Add(this.answerDButton);
            this.Controls.Add(this.answerCButton);
            this.Controls.Add(this.answerBButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.answerAButton);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerAButton;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button answerBButton;
        private System.Windows.Forms.Button answerCButton;
        private System.Windows.Forms.Button answerDButton;
        private System.Windows.Forms.Button answerEButton;
    }
}