namespace ex7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxMouse = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheese = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheese)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxMouse
            // 
            this.pictureBoxMouse.Image = global::ex7.Properties.Resources.mouse;
            this.pictureBoxMouse.Location = new System.Drawing.Point(720, 377);
            this.pictureBoxMouse.Name = "pictureBoxMouse";
            this.pictureBoxMouse.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxMouse.TabIndex = 1;
            this.pictureBoxMouse.TabStop = false;
            // 
            // pictureBoxCheese
            // 
            this.pictureBoxCheese.Image = global::ex7.Properties.Resources.cheese;
            this.pictureBoxCheese.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheese.InitialImage")));
            this.pictureBoxCheese.Location = new System.Drawing.Point(12, 110);
            this.pictureBoxCheese.Name = "pictureBoxCheese";
            this.pictureBoxCheese.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCheese.TabIndex = 0;
            this.pictureBoxCheese.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxMouse);
            this.Controls.Add(this.pictureBoxCheese);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheese)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxCheese;
        private System.Windows.Forms.PictureBox pictureBoxMouse;
        private System.Windows.Forms.Timer timer2;
    }
}

