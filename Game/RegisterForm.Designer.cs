
namespace Game
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.TextBoxPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonStartGame = new System.Windows.Forms.Button();
            this.ShowResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxPlayerName
            // 
            this.TextBoxPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPlayerName.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPlayerName.Location = new System.Drawing.Point(82, 116);
            this.TextBoxPlayerName.Name = "TextBoxPlayerName";
            this.TextBoxPlayerName.Size = new System.Drawing.Size(367, 35);
            this.TextBoxPlayerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(129, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя пользователя";
            // 
            // ButtonStartGame
            // 
            this.ButtonStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStartGame.BackColor = System.Drawing.Color.Moccasin;
            this.ButtonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonStartGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStartGame.Location = new System.Drawing.Point(284, 251);
            this.ButtonStartGame.Name = "ButtonStartGame";
            this.ButtonStartGame.Size = new System.Drawing.Size(165, 69);
            this.ButtonStartGame.TabIndex = 2;
            this.ButtonStartGame.Text = "Начать игру";
            this.ButtonStartGame.UseVisualStyleBackColor = false;
            this.ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // ShowResults
            // 
            this.ShowResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowResults.BackColor = System.Drawing.Color.Moccasin;
            this.ShowResults.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowResults.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowResults.Location = new System.Drawing.Point(82, 251);
            this.ShowResults.Name = "ShowResults";
            this.ShowResults.Size = new System.Drawing.Size(165, 69);
            this.ShowResults.TabIndex = 3;
            this.ShowResults.Text = "Результаты";
            this.ShowResults.UseVisualStyleBackColor = false;
            this.ShowResults.Click += new System.EventHandler(this.ShowResults_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(534, 495);
            this.Controls.Add(this.ShowResults);
            this.Controls.Add(this.ButtonStartGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPlayerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 534);
            this.MinimumSize = new System.Drawing.Size(550, 534);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonStartGame;
        private System.Windows.Forms.Button ShowResults;
    }
}