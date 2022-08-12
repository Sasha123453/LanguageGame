namespace LanguageGame
{
    partial class LevelsForm
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
            this.background = new System.Windows.Forms.Panel();
            this.levelsPanel = new System.Windows.Forms.Panel();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.background.Controls.Add(this.levelsPanel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(0);
            this.background.Name = "background";
            this.background.Padding = new System.Windows.Forms.Padding(5);
            this.background.Size = new System.Drawing.Size(482, 353);
            this.background.TabIndex = 0;
            // 
            // levelsPanel
            // 
            this.levelsPanel.AutoScroll = true;
            this.levelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelsPanel.Location = new System.Drawing.Point(5, 5);
            this.levelsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.levelsPanel.Name = "levelsPanel";
            this.levelsPanel.Size = new System.Drawing.Size(472, 343);
            this.levelsPanel.TabIndex = 0;
            // 
            // LevelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LevelsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать Уровень";
            this.background.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel background;
        private Panel levelsPanel;
    }
}