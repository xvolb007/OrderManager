namespace OrderManager
{
    partial class Main
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
            this.Table1 = new System.Windows.Forms.Button();
            this.Table4 = new System.Windows.Forms.Button();
            this.Table3 = new System.Windows.Forms.Button();
            this.Table5 = new System.Windows.Forms.Button();
            this.Table2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Table1
            // 
            this.Table1.Location = new System.Drawing.Point(100, 53);
            this.Table1.Name = "Table1";
            this.Table1.Size = new System.Drawing.Size(102, 108);
            this.Table1.TabIndex = 0;
            this.Table1.Text = "Table1";
            this.Table1.UseVisualStyleBackColor = true;
            this.Table1.Click += new System.EventHandler(this.Table1_Click);
            // 
            // Table4
            // 
            this.Table4.Location = new System.Drawing.Point(100, 250);
            this.Table4.Name = "Table4";
            this.Table4.Size = new System.Drawing.Size(102, 108);
            this.Table4.TabIndex = 1;
            this.Table4.Text = "Table4";
            this.Table4.UseVisualStyleBackColor = true;
            this.Table4.Click += new System.EventHandler(this.Table4_Click);
            // 
            // Table3
            // 
            this.Table3.Location = new System.Drawing.Point(561, 40);
            this.Table3.Name = "Table3";
            this.Table3.Size = new System.Drawing.Size(147, 135);
            this.Table3.TabIndex = 2;
            this.Table3.Text = "Table3";
            this.Table3.UseVisualStyleBackColor = true;
            this.Table3.Click += new System.EventHandler(this.Table3_Click);
            // 
            // Table5
            // 
            this.Table5.Location = new System.Drawing.Point(561, 223);
            this.Table5.Name = "Table5";
            this.Table5.Size = new System.Drawing.Size(147, 135);
            this.Table5.TabIndex = 3;
            this.Table5.Text = "Table5";
            this.Table5.UseVisualStyleBackColor = true;
            this.Table5.Click += new System.EventHandler(this.Table5_Click);
            // 
            // Table2
            // 
            this.Table2.Location = new System.Drawing.Point(310, 40);
            this.Table2.Name = "Table2";
            this.Table2.Size = new System.Drawing.Size(147, 135);
            this.Table2.TabIndex = 4;
            this.Table2.Text = "Table2";
            this.Table2.UseVisualStyleBackColor = true;
            this.Table2.Click += new System.EventHandler(this.Table2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Table2);
            this.Controls.Add(this.Table5);
            this.Controls.Add(this.Table3);
            this.Controls.Add(this.Table4);
            this.Controls.Add(this.Table1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Table1;
        private System.Windows.Forms.Button Table4;
        private System.Windows.Forms.Button Table3;
        private System.Windows.Forms.Button Table5;
        private System.Windows.Forms.Button Table2;
    }
}

