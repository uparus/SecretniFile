namespace Ex9
{
    partial class Form1
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
            this.NewTriangleButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StepsLabel = new System.Windows.Forms.Label();
            this.StepsTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewTriangleButton
            // 
            this.NewTriangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewTriangleButton.Location = new System.Drawing.Point(20, 20);
            this.NewTriangleButton.Name = "NewTriangleButton";
            this.NewTriangleButton.Size = new System.Drawing.Size(250, 35);
            this.NewTriangleButton.TabIndex = 0;
            this.NewTriangleButton.Text = "Изобразить новый треугольник";
            this.NewTriangleButton.UseVisualStyleBackColor = true;
            this.NewTriangleButton.Click += new System.EventHandler(this.NewTriangleButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(290, 20);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 35);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StepsLabel
            // 
            this.StepsLabel.AutoSize = true;
            this.StepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepsLabel.Location = new System.Drawing.Point(410, 28);
            this.StepsLabel.Name = "StepsLabel";
            this.StepsLabel.Size = new System.Drawing.Size(130, 16);
            this.StepsLabel.TabIndex = 2;
            this.StepsLabel.Text = "Количество шагов:";
            // 
            // StepsTextBox
            // 
            this.StepsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepsTextBox.Location = new System.Drawing.Point(560, 25);
            this.StepsTextBox.Name = "StepsTextBox";
            this.StepsTextBox.Size = new System.Drawing.Size(100, 22);
            this.StepsTextBox.TabIndex = 3;
            this.StepsTextBox.Text = "1000";
            this.StepsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(680, 28);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 16);
            this.InfoLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.StepsTextBox);
            this.Controls.Add(this.StepsLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.NewTriangleButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Закономерность хаоса";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewTriangleButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label StepsLabel;
        private System.Windows.Forms.TextBox StepsTextBox;
        private System.Windows.Forms.Label InfoLabel;
    }
}

