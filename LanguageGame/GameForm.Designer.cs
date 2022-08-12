namespace LanguageGame
{
    partial class GameForm
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.sky = new System.Windows.Forms.Panel();
            this.levelresult = new System.Windows.Forms.Label();
            this.levelsButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.heartPanel = new System.Windows.Forms.Panel();
            this.healts = new System.Windows.Forms.Panel();
            this.railWay = new System.Windows.Forms.Panel();
            this.picturesPanel = new System.Windows.Forms.Panel();
            this.gamePanel.SuspendLayout();
            this.sky.SuspendLayout();
            this.heartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.YellowGreen;
            this.gamePanel.Controls.Add(this.sky);
            this.gamePanel.Controls.Add(this.railWay);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1262, 493);
            this.gamePanel.TabIndex = 0;
            // 
            // sky
            // 
            this.sky.BackColor = System.Drawing.Color.Turquoise;
            this.sky.Controls.Add(this.levelresult);
            this.sky.Controls.Add(this.levelsButton);
            this.sky.Controls.Add(this.playButton);
            this.sky.Controls.Add(this.nameLabel);
            this.sky.Controls.Add(this.heartPanel);
            this.sky.Location = new System.Drawing.Point(0, 0);
            this.sky.Margin = new System.Windows.Forms.Padding(0);
            this.sky.Name = "sky";
            this.sky.Size = new System.Drawing.Size(1262, 240);
            this.sky.TabIndex = 1;
            // 
            // levelresult
            // 
            this.levelresult.AutoSize = true;
            this.levelresult.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.levelresult.Location = new System.Drawing.Point(287, 15);
            this.levelresult.Margin = new System.Windows.Forms.Padding(0);
            this.levelresult.Name = "levelresult";
            this.levelresult.Size = new System.Drawing.Size(285, 112);
            this.levelresult.TabIndex = 4;
            this.levelresult.Text = "label1";
            this.levelresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelsButton
            // 
            this.levelsButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.levelsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.levelsButton.Location = new System.Drawing.Point(10, 130);
            this.levelsButton.Margin = new System.Windows.Forms.Padding(0);
            this.levelsButton.Name = "levelsButton";
            this.levelsButton.Size = new System.Drawing.Size(250, 50);
            this.levelsButton.TabIndex = 3;
            this.levelsButton.Text = "Выбрать уровень";
            this.levelsButton.UseVisualStyleBackColor = false;
            this.levelsButton.Click += new System.EventHandler(this.ChooseLevelButtonClick);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playButton.Location = new System.Drawing.Point(10, 70);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(250, 50);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Начать";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.StartLevel);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(1167, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 46);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "text";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // heartPanel
            // 
            this.heartPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.heartPanel.Controls.Add(this.healts);
            this.heartPanel.Location = new System.Drawing.Point(10, 10);
            this.heartPanel.Margin = new System.Windows.Forms.Padding(0);
            this.heartPanel.Name = "heartPanel";
            this.heartPanel.Padding = new System.Windows.Forms.Padding(5);
            this.heartPanel.Size = new System.Drawing.Size(250, 50);
            this.heartPanel.TabIndex = 0;
            // 
            // healts
            // 
            this.healts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.healts.Location = new System.Drawing.Point(5, 5);
            this.healts.Name = "healts";
            this.healts.Size = new System.Drawing.Size(240, 40);
            this.healts.TabIndex = 0;
            // 
            // railWay
            // 
            this.railWay.BackColor = System.Drawing.Color.DarkSlateGray;
            this.railWay.Location = new System.Drawing.Point(0, 425);
            this.railWay.Margin = new System.Windows.Forms.Padding(0);
            this.railWay.Name = "railWay";
            this.railWay.Size = new System.Drawing.Size(1262, 10);
            this.railWay.TabIndex = 0;
            // 
            // picturesPanel
            // 
            this.picturesPanel.AutoScroll = true;
            this.picturesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picturesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picturesPanel.Location = new System.Drawing.Point(0, 493);
            this.picturesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.picturesPanel.Name = "picturesPanel";
            this.picturesPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.picturesPanel.Size = new System.Drawing.Size(1262, 180);
            this.picturesPanel.TabIndex = 2;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.picturesPanel);
            this.Controls.Add(this.gamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "GameForm";
            this.Text = "Game";
            this.gamePanel.ResumeLayout(false);
            this.sky.ResumeLayout(false);
            this.sky.PerformLayout();
            this.heartPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel gamePanel;
        private Panel picturesPanel;
        private Panel railWay;
        private Panel sky;
        private Label nameLabel;
        private Panel heartPanel;
        private Button playButton;
        private Button levelsButton;
        private Panel healts;
        private Label levelresult;
    }
}