namespace TicTacToe
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.PickModeLabel = new System.Windows.Forms.Label();
            this.PlayerPlayerBtn = new System.Windows.Forms.Button();
            this.PlayerAiBtn = new System.Windows.Forms.Button();
            this.AiAIBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(85, 20);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(115, 15);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Добро пожаловать!";
            // 
            // PickModeLabel
            // 
            this.PickModeLabel.AutoSize = true;
            this.PickModeLabel.Location = new System.Drawing.Point(90, 50);
            this.PickModeLabel.Name = "PickModeLabel";
            this.PickModeLabel.Size = new System.Drawing.Size(105, 15);
            this.PickModeLabel.TabIndex = 1;
            this.PickModeLabel.Text = "Выберите режим:";
            // 
            // PlayerPlayerBtn
            // 
            this.PlayerPlayerBtn.Location = new System.Drawing.Point(65, 80);
            this.PlayerPlayerBtn.Name = "PlayerPlayerBtn";
            this.PlayerPlayerBtn.Size = new System.Drawing.Size(150, 25);
            this.PlayerPlayerBtn.TabIndex = 2;
            this.PlayerPlayerBtn.Text = "Игрок-Игрок";
            this.PlayerPlayerBtn.UseVisualStyleBackColor = true;
            this.PlayerPlayerBtn.Click += new System.EventHandler(this.PlayerPlayerBtn_Click);
            // 
            // PlayerAiBtn
            // 
            this.PlayerAiBtn.Location = new System.Drawing.Point(65, 120);
            this.PlayerAiBtn.Name = "PlayerAiBtn";
            this.PlayerAiBtn.Size = new System.Drawing.Size(150, 25);
            this.PlayerAiBtn.TabIndex = 3;
            this.PlayerAiBtn.Text = "Игрок-Компьютер";
            this.PlayerAiBtn.UseVisualStyleBackColor = true;
            this.PlayerAiBtn.Click += new System.EventHandler(this.PlayerAiBtn_Click);
            // 
            // AiAIBtn
            // 
            this.AiAIBtn.Location = new System.Drawing.Point(65, 160);
            this.AiAIBtn.Name = "AiAIBtn";
            this.AiAIBtn.Size = new System.Drawing.Size(150, 25);
            this.AiAIBtn.TabIndex = 4;
            this.AiAIBtn.Text = "Компьютер-Компьютер";
            this.AiAIBtn.UseVisualStyleBackColor = true;
            this.AiAIBtn.Click += new System.EventHandler(this.AiAIBtn_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AiAIBtn);
            this.Controls.Add(this.PlayerAiBtn);
            this.Controls.Add(this.PlayerPlayerBtn);
            this.Controls.Add(this.PickModeLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label PickModeLabel;
        private System.Windows.Forms.Button PlayerPlayerBtn;
        private System.Windows.Forms.Button PlayerAiBtn;
        private System.Windows.Forms.Button AiAIBtn;
    }
}
