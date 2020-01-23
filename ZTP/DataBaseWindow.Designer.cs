namespace ZTP
{
    partial class DatabaseWindow
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
            this.startButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.listBoxPol = new System.Windows.Forms.ListBox();
            this.listBoxEng = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.startButton.Location = new System.Drawing.Point(43, 414);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(260, 52);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "DODAJ SŁOWO";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(317, 414);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(254, 52);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "USUN SŁOWO";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.editButton.Location = new System.Drawing.Point(587, 414);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(261, 52);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "EDYTUJ SŁOWO";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(723, 493);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(244, 52);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "POWRÓT";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // listBoxPol
            // 
            this.listBoxPol.FormattingEnabled = true;
            this.listBoxPol.Location = new System.Drawing.Point(92, 72);
            this.listBoxPol.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPol.Name = "listBoxPol";
            this.listBoxPol.Size = new System.Drawing.Size(256, 277);
            this.listBoxPol.TabIndex = 7;
            // 
            // listBoxEng
            // 
            this.listBoxEng.FormattingEnabled = true;
            this.listBoxEng.Location = new System.Drawing.Point(587, 72);
            this.listBoxEng.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEng.Name = "listBoxEng";
            this.listBoxEng.Size = new System.Drawing.Size(256, 277);
            this.listBoxEng.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(140, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "POLSKIE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(619, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "ANGIELSKIE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1005, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxEng);
            this.Controls.Add(this.listBoxPol);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatabaseWindow";
            this.Text = "DataBaseWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox listBoxPol;
        private System.Windows.Forms.ListBox listBoxEng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}