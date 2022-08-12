namespace LanguageGame
{
    partial class Carriage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StrokePanel = new System.Windows.Forms.Panel();
            this.insidePanel = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.Label();
            this.wheelsPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StrokePanel.SuspendLayout();
            this.insidePanel.SuspendLayout();
            this.wheelsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StrokePanel
            // 
            this.StrokePanel.BackColor = System.Drawing.Color.Gray;
            this.StrokePanel.Controls.Add(this.insidePanel);
            this.StrokePanel.Location = new System.Drawing.Point(10, 0);
            this.StrokePanel.Margin = new System.Windows.Forms.Padding(0);
            this.StrokePanel.Name = "StrokePanel";
            this.StrokePanel.Padding = new System.Windows.Forms.Padding(10);
            this.StrokePanel.Size = new System.Drawing.Size(180, 140);
            this.StrokePanel.TabIndex = 0;
            // 
            // insidePanel
            // 
            this.insidePanel.BackColor = System.Drawing.Color.White;
            this.insidePanel.Controls.Add(this.text);
            this.insidePanel.Location = new System.Drawing.Point(10, 10);
            this.insidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.insidePanel.Name = "insidePanel";
            this.insidePanel.Size = new System.Drawing.Size(160, 120);
            this.insidePanel.TabIndex = 0;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Transparent;
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Margin = new System.Windows.Forms.Padding(0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(160, 120);
            this.text.TabIndex = 1;
            this.text.Text = "Simple";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wheelsPanel
            // 
            this.wheelsPanel.BackColor = System.Drawing.Color.Transparent;
            this.wheelsPanel.Controls.Add(this.pictureBox2);
            this.wheelsPanel.Controls.Add(this.pictureBox1);
            this.wheelsPanel.Location = new System.Drawing.Point(0, 140);
            this.wheelsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.wheelsPanel.Name = "wheelsPanel";
            this.wheelsPanel.Size = new System.Drawing.Size(200, 40);
            this.wheelsPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(125, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(35, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomPanel.ForeColor = System.Drawing.Color.Black;
            this.bottomPanel.Location = new System.Drawing.Point(0, 130);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(200, 20);
            this.bottomPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 70);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(190, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 50);
            this.panel2.TabIndex = 4;
            // 
            // Carriage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.wheelsPanel);
            this.Controls.Add(this.StrokePanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Carriage";
            this.Size = new System.Drawing.Size(200, 160);
            this.StrokePanel.ResumeLayout(false);
            this.insidePanel.ResumeLayout(false);
            this.wheelsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel StrokePanel;
        private Panel insidePanel;
        private Label text;
        private Panel wheelsPanel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel bottomPanel;
        private Panel panel1;
        private Panel panel2;
    }
}
