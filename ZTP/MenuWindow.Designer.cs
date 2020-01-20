namespace ZTP
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
            this.SuspendLayout();
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.difficultyLabel.Location = new System.Drawing.Point(133, 102);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(300, 32);
            this.difficultyLabel.TabIndex = 0;
            this.difficultyLabel.Text = "DIFFICULTY LEVEL";
            // 
            // learningModelLabel
            // 
            this.learningModelLabel.AutoSize = true;
            this.learningModelLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.learningModelLabel.Location = new System.Drawing.Point(133, 163);
            this.learningModelLabel.Name = "learningModelLabel";
            this.learningModelLabel.Size = new System.Drawing.Size(273, 32);
            this.learningModelLabel.TabIndex = 1;
            this.learningModelLabel.Text = "LEARNING MODE";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.startButton.Location = new System.Drawing.Point(321, 280);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(164, 52);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.learningModelLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Name = "MenuWindow";
            this.Text = "Englearn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label learningModelLabel;
        private System.Windows.Forms.Button startButton;
    }
}

