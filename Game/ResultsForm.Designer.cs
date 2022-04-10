
namespace Game
{
    partial class ResultsForm
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
            this.ResultsofGame = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsofGame)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsofGame
            // 
            this.ResultsofGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsofGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsofGame.Location = new System.Drawing.Point(0, 0);
            this.ResultsofGame.Name = "ResultsofGame";
            this.ResultsofGame.ReadOnly = true;
            this.ResultsofGame.Size = new System.Drawing.Size(808, 473);
            this.ResultsofGame.TabIndex = 0;
            this.ResultsofGame.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultsofGame_CellContentClick);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 473);
            this.Controls.Add(this.ResultsofGame);
            this.Name = "ResultsForm";
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsofGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultsofGame;
    }
}