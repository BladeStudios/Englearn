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
            this.wordLabel = new System.Windows.Forms.Label();
            this.answerBButton = new System.Windows.Forms.Button();
            this.answerCButton = new System.Windows.Forms.Button();
            this.answerDButton = new System.Windows.Forms.Button();
            this.answerEButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerAButton
            // 
            this.answerAButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.answerAButton.Location = new System.Drawing.Point(260, 162);
            this.answerAButton.Name = "answerAButton";
            this.answerAButton.Size = new System.Drawing.Size(473, 41);
            this.answerAButton.TabIndex = 3;
            this.answerAButton.Text = "odpowiedźA";
            this.answerAButton.UseVisualStyleBackColor = true;
            this.answerAButton.Click += new System.EventHandler(this.answerAButton_Click);
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
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.wordLabel.ForeColor = System.Drawing.Color.Black;
            this.wordLabel.Location = new System.Drawing.Point(423, 117);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(127, 32);
            this.wordLabel.TabIndex = 9;
            this.wordLabel.Text = "SŁOWO";
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // answerBButton
            // 
            this.answerBButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.answerBButton.Location = new System.Drawing.Point(260, 209);
            this.answerBButton.Name = "answerBButton";
            this.answerBButton.Size = new System.Drawing.Size(473, 41);
            this.answerBButton.TabIndex = 10;
            this.answerBButton.Text = "odpowiedźB";
            this.answerBButton.UseVisualStyleBackColor = true;
            this.answerBButton.Click += new System.EventHandler(this.answerBButton_Click);
            // 
            // answerCButton
            // 
            this.answerCButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.answerCButton.Location = new System.Drawing.Point(260, 256);
            this.answerCButton.Name = "answerCButton";
            this.answerCButton.Size = new System.Drawing.Size(473, 41);
            this.answerCButton.TabIndex = 11;
            this.answerCButton.Text = "odpowiedźC";
            this.answerCButton.UseVisualStyleBackColor = true;
            this.answerCButton.Click += new System.EventHandler(this.answerCButton_Click);
            // 
            // answerDButton
            // 
            this.answerDButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.answerDButton.Location = new System.Drawing.Point(260, 303);
            this.answerDButton.Name = "answerDButton";
            this.answerDButton.Size = new System.Drawing.Size(473, 41);
            this.answerDButton.TabIndex = 12;
            this.answerDButton.Text = "odpowiedźD";
            this.answerDButton.UseVisualStyleBackColor = true;
            this.answerDButton.Click += new System.EventHandler(this.answerDButton_Click);
            // 
            // answerEButton
            // 
            this.answerEButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.answerEButton.Location = new System.Drawing.Point(260, 350);
            this.answerEButton.Name = "answerEButton";
            this.answerEButton.Size = new System.Drawing.Size(473, 41);
            this.answerEButton.TabIndex = 13;
            this.answerEButton.Text = "odpowiedźE";
            this.answerEButton.UseVisualStyleBackColor = true;
            this.answerEButton.Click += new System.EventHandler(this.answerEButton_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1005, 576);
            this.Controls.Add(this.answerEButton);
            this.Controls.Add(this.answerDButton);
            this.Controls.Add(this.answerCButton);
            this.Controls.Add(this.answerBButton);
            this.Controls.Add(this.wordLabel);
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
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Button answerBButton;
        private System.Windows.Forms.Button answerCButton;
        private System.Windows.Forms.Button answerDButton;
        private System.Windows.Forms.Button answerEButton;
    }
}