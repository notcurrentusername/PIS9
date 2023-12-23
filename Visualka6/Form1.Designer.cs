namespace Visualka6
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
            this.lineChart1 = new Visualka6.LineChart();
            this.SuspendLayout();
            // 
            // lineChart1
            // 
            this.lineChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineChart1.AutoSize = true;
            this.lineChart1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lineChart1.Location = new System.Drawing.Point(-4, 0);
            this.lineChart1.Margin = new System.Windows.Forms.Padding(5);
            this.lineChart1.Name = "lineChart1";
            this.lineChart1.Size = new System.Drawing.Size(807, 539);
            this.lineChart1.TabIndex = 0;
            this.lineChart1.Load += new System.EventHandler(this.lineChart1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(819, 554);
            this.Controls.Add(this.lineChart1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LineChart lineChart1;
    }
}

