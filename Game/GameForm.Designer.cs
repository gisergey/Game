
namespace Game
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerForAnimation = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.PointLabel = new System.Windows.Forms.Label();
            this.FirstSelectedpictureAnimationTiimer = new System.Windows.Forms.Timer(this.components);
            this.SecondSelectedPictureAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // TimerForAnimation
            // 
            this.TimerForAnimation.Interval = 10;
            this.TimerForAnimation.Tick += new System.EventHandler(this.TimerForAnimation_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(992, 916);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(174, 64);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "label1";
            this.TimerLabel.Click += new System.EventHandler(this.TimerLabel_Click);
            // 
            // PointLabel
            // 
            this.PointLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PointLabel.AutoSize = true;
            this.PointLabel.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointLabel.Location = new System.Drawing.Point(812, 916);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(174, 64);
            this.PointLabel.TabIndex = 1;
            this.PointLabel.Text = "label1";
            // 
            // FirstSelectedpictureAnimationTiimer
            // 
            this.FirstSelectedpictureAnimationTiimer.Interval = 10;
            this.FirstSelectedpictureAnimationTiimer.Tick += new System.EventHandler(this.FirstSelectedpictureAnimationTiimer_Tick);
            // 
            // SecondSelectedPictureAnimationTimer
            // 
            this.SecondSelectedPictureAnimationTimer.Interval = 10;
            this.SecondSelectedPictureAnimationTimer.Tick += new System.EventHandler(this.SecondSelectedPictureAnimationTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 989);
            this.Controls.Add(this.PointLabel);
            this.Controls.Add(this.TimerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1194, 1028);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра найди мем";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Timer TimerForAnimation;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label PointLabel;
        private System.Windows.Forms.Timer FirstSelectedpictureAnimationTiimer;
        private System.Windows.Forms.Timer SecondSelectedPictureAnimationTimer;
    }
}

