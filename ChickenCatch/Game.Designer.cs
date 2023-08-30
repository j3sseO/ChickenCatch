namespace ChickenCatch
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._animationTimer = new System.Windows.Forms.Timer(this.components);
            this._scoreCount = new System.Windows.Forms.Label();
            this._lifeCount = new System.Windows.Forms.Label();
            this._playLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _pictureBox
            // 
            this._pictureBox.BackColor = System.Drawing.SystemColors.Info;
            this._pictureBox.Location = new System.Drawing.Point(-1, -1);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(801, 520);
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            this._pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePaint);
            // 
            // _animationTimer
            // 
            this._animationTimer.Interval = 5;
            this._animationTimer.Tick += new System.EventHandler(this.AnimationTimerTick);
            // 
            // _scoreCount
            // 
            this._scoreCount.AutoSize = true;
            this._scoreCount.Location = new System.Drawing.Point(708, 233);
            this._scoreCount.Name = "_scoreCount";
            this._scoreCount.Size = new System.Drawing.Size(48, 15);
            this._scoreCount.TabIndex = 1;
            this._scoreCount.Text = "Score: 0";
            // 
            // _lifeCount
            // 
            this._lifeCount.AutoSize = true;
            this._lifeCount.Location = new System.Drawing.Point(708, 272);
            this._lifeCount.Name = "_lifeCount";
            this._lifeCount.Size = new System.Drawing.Size(48, 15);
            this._lifeCount.TabIndex = 2;
            this._lifeCount.Text = "Score: 0";
            // 
            // _playLabel
            // 
            this._playLabel.AutoSize = true;
            this._playLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._playLabel.Location = new System.Drawing.Point(300, 244);
            this._playLabel.Name = "_playLabel";
            this._playLabel.Size = new System.Drawing.Size(174, 25);
            this._playLabel.TabIndex = 3;
            this._playLabel.Text = "Press Enter To Play!";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this._playLabel);
            this.Controls.Add(this._lifeCount);
            this.Controls.Add(this._scoreCount);
            this.Controls.Add(this._pictureBox);
            this.Name = "Game";
            this.Text = "Chicken Catch";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox _pictureBox;
        private System.Windows.Forms.Timer _animationTimer;
        private Label _scoreCount;
        private Label _lifeCount;
        private Label _playLabel;
    }
}