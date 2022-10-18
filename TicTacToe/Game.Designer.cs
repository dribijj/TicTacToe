namespace TicTacToe
{
    partial class Game
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
            this.RestartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RestartBtn
            // 
            this.RestartBtn.Location = new System.Drawing.Point(0, 0);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(600, 50);
            this.RestartBtn.TabIndex = 0;
            this.RestartBtn.Text = "Начать заново";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 611);
            this.Controls.Add(this.RestartBtn);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RestartBtn;
    }
}