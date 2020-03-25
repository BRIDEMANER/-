namespace PROJECT
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
            this.cube = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeScr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cube)).BeginInit();
            this.SuspendLayout();
            // 
            // cube
            // 
            this.cube.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cube.Location = new System.Drawing.Point(0, 0);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(40, 40);
            this.cube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cube.TabIndex = 0;
            this.cube.TabStop = false;
            this.cube.Visible = false;
            this.cube.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labeScr
            // 
            this.labeScr.AutoSize = true;
            this.labeScr.Location = new System.Drawing.Point(481, 9);
            this.labeScr.Name = "labeScr";
            this.labeScr.Size = new System.Drawing.Size(35, 13);
            this.labeScr.TabIndex = 1;
            this.labeScr.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 417);
            this.Controls.Add(this.labeScr);
            this.Controls.Add(this.cube);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cube;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeScr;
    }
}

