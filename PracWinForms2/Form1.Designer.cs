namespace PracWinForms2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name1_TextBox = new System.Windows.Forms.TextBox();
            this.Name2_TextBox = new System.Windows.Forms.TextBox();
            this.Name3_TextBox = new System.Windows.Forms.TextBox();
            this.Count3_TextBox = new System.Windows.Forms.TextBox();
            this.Count2_TextBox = new System.Windows.Forms.TextBox();
            this.Count1_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sum_Button = new System.Windows.Forms.Button();
            this.Sum_TextBox = new System.Windows.Forms.TextBox();
            this.Max_TextBox = new System.Windows.Forms.TextBox();
            this.Max_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имена";
            // 
            // Name1_TextBox
            // 
            this.Name1_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name1_TextBox.Location = new System.Drawing.Point(123, 33);
            this.Name1_TextBox.Name = "Name1_TextBox";
            this.Name1_TextBox.Size = new System.Drawing.Size(150, 23);
            this.Name1_TextBox.TabIndex = 1;
            // 
            // Name2_TextBox
            // 
            this.Name2_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name2_TextBox.Location = new System.Drawing.Point(308, 33);
            this.Name2_TextBox.Name = "Name2_TextBox";
            this.Name2_TextBox.Size = new System.Drawing.Size(150, 23);
            this.Name2_TextBox.TabIndex = 2;
            // 
            // Name3_TextBox
            // 
            this.Name3_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name3_TextBox.Location = new System.Drawing.Point(493, 33);
            this.Name3_TextBox.Name = "Name3_TextBox";
            this.Name3_TextBox.Size = new System.Drawing.Size(150, 23);
            this.Name3_TextBox.TabIndex = 3;
            // 
            // Count3_TextBox
            // 
            this.Count3_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count3_TextBox.Location = new System.Drawing.Point(493, 87);
            this.Count3_TextBox.Name = "Count3_TextBox";
            this.Count3_TextBox.Size = new System.Drawing.Size(150, 23);
            this.Count3_TextBox.TabIndex = 7;
            // 
            // Count2_TextBox
            // 
            this.Count2_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count2_TextBox.Location = new System.Drawing.Point(308, 87);
            this.Count2_TextBox.Name = "Count2_TextBox";
            this.Count2_TextBox.Size = new System.Drawing.Size(150, 23);
            this.Count2_TextBox.TabIndex = 6;
            // 
            // Count1_TextBox
            // 
            this.Count1_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count1_TextBox.Location = new System.Drawing.Point(123, 87);
            this.Count1_TextBox.Name = "Count1_TextBox";
            this.Count1_TextBox.Size = new System.Drawing.Size(150, 23);
            this.Count1_TextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кол-во";
            // 
            // Sum_Button
            // 
            this.Sum_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum_Button.Location = new System.Drawing.Point(192, 156);
            this.Sum_Button.Name = "Sum_Button";
            this.Sum_Button.Size = new System.Drawing.Size(97, 33);
            this.Sum_Button.TabIndex = 8;
            this.Sum_Button.Text = "Сумма";
            this.Sum_Button.UseVisualStyleBackColor = true;
            this.Sum_Button.Click += new System.EventHandler(this.Sum_Button_Click);
            // 
            // Sum_TextBox
            // 
            this.Sum_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum_TextBox.Location = new System.Drawing.Point(326, 162);
            this.Sum_TextBox.Name = "Sum_TextBox";
            this.Sum_TextBox.Size = new System.Drawing.Size(150, 23);
            this.Sum_TextBox.TabIndex = 9;
            // 
            // Max_TextBox
            // 
            this.Max_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Max_TextBox.Location = new System.Drawing.Point(326, 210);
            this.Max_TextBox.Multiline = true;
            this.Max_TextBox.Name = "Max_TextBox";
            this.Max_TextBox.Size = new System.Drawing.Size(150, 62);
            this.Max_TextBox.TabIndex = 11;
            // 
            // Max_Button
            // 
            this.Max_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Max_Button.Location = new System.Drawing.Point(192, 225);
            this.Max_Button.Name = "Max_Button";
            this.Max_Button.Size = new System.Drawing.Size(97, 33);
            this.Max_Button.TabIndex = 10;
            this.Max_Button.Text = "Максимум";
            this.Max_Button.UseVisualStyleBackColor = true;
            this.Max_Button.Click += new System.EventHandler(this.Max_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(678, 300);
            this.Controls.Add(this.Max_TextBox);
            this.Controls.Add(this.Max_Button);
            this.Controls.Add(this.Sum_TextBox);
            this.Controls.Add(this.Sum_Button);
            this.Controls.Add(this.Count3_TextBox);
            this.Controls.Add(this.Count2_TextBox);
            this.Controls.Add(this.Count1_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name3_TextBox);
            this.Controls.Add(this.Name2_TextBox);
            this.Controls.Add(this.Name1_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name1_TextBox;
        private System.Windows.Forms.TextBox Name2_TextBox;
        private System.Windows.Forms.TextBox Name3_TextBox;
        private System.Windows.Forms.TextBox Count3_TextBox;
        private System.Windows.Forms.TextBox Count2_TextBox;
        private System.Windows.Forms.TextBox Count1_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sum_Button;
        private System.Windows.Forms.TextBox Sum_TextBox;
        private System.Windows.Forms.TextBox Max_TextBox;
        private System.Windows.Forms.Button Max_Button;
    }
}

