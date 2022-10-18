namespace TicTacToe
{
    partial class SizePage
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
            this.Btn3x3 = new System.Windows.Forms.Button();
            this.SizeModeLabel = new System.Windows.Forms.Label();
            this.Btn5x5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn3x3
            // 
            this.Btn3x3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn3x3.Location = new System.Drawing.Point(40, 100);
            this.Btn3x3.Name = "Btn3x3";
            this.Btn3x3.Size = new System.Drawing.Size(75, 75);
            this.Btn3x3.TabIndex = 0;
            this.Btn3x3.Text = "3x3";
            this.Btn3x3.UseVisualStyleBackColor = true;
            this.Btn3x3.Click += new System.EventHandler(this.Btn3x3_Click);
            // 
            // SizeModeLabel
            // 
            this.SizeModeLabel.AutoSize = true;
            this.SizeModeLabel.Location = new System.Drawing.Point(80, 50);
            this.SizeModeLabel.Name = "SizeModeLabel";
            this.SizeModeLabel.Size = new System.Drawing.Size(137, 15);
            this.SizeModeLabel.TabIndex = 2;
            this.SizeModeLabel.Text = "Выберите размер поля:";
            // 
            // Btn5x5
            // 
            this.Btn5x5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn5x5.Location = new System.Drawing.Point(175, 100);
            this.Btn5x5.Name = "Btn5x5";
            this.Btn5x5.Size = new System.Drawing.Size(75, 75);
            this.Btn5x5.TabIndex = 3;
            this.Btn5x5.Text = "5x5";
            this.Btn5x5.UseVisualStyleBackColor = true;
            this.Btn5x5.Click += new System.EventHandler(this.Btn5x5_Click);
            // 
            // SizePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Btn5x5);
            this.Controls.Add(this.SizeModeLabel);
            this.Controls.Add(this.Btn3x3);
            this.Name = "SizePage";
            this.Text = "SizePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn3x3;
        private System.Windows.Forms.Label SizeModeLabel;
        private System.Windows.Forms.Button Btn5x5;
    }
}