namespace LAB_VM6
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterTextBox = new System.Windows.Forms.TextBox();
            this.ChordTextBox = new System.Windows.Forms.TextBox();
            this.TangentTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AccuracyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BeginTextBox = new System.Windows.Forms.TextBox();
            this.EndTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите значение х (для метода касательных): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число итераций по методу хорд: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Число итераций по методу касательных:";
            // 
            // EnterTextBox
            // 
            this.EnterTextBox.Location = new System.Drawing.Point(264, 6);
            this.EnterTextBox.Name = "EnterTextBox";
            this.EnterTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnterTextBox.TabIndex = 1;
            // 
            // ChordTextBox
            // 
            this.ChordTextBox.Location = new System.Drawing.Point(193, 60);
            this.ChordTextBox.Name = "ChordTextBox";
            this.ChordTextBox.ReadOnly = true;
            this.ChordTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChordTextBox.TabIndex = 6;
            // 
            // TangentTextBox
            // 
            this.TangentTextBox.Location = new System.Drawing.Point(233, 84);
            this.TangentTextBox.Name = "TangentTextBox";
            this.TangentTextBox.ReadOnly = true;
            this.TangentTextBox.Size = new System.Drawing.Size(100, 20);
            this.TangentTextBox.TabIndex = 7;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(12, 110);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(338, 23);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Не знаю, как назвать, просто жми сюда после ввода данных!";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите точность: ";
            // 
            // AccuracyTextBox
            // 
            this.AccuracyTextBox.Location = new System.Drawing.Point(121, 34);
            this.AccuracyTextBox.Name = "AccuracyTextBox";
            this.AccuracyTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccuracyTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите первое значение (для метода хорд): ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Введите второе значение (для метода хорд): ";
            // 
            // BeginTextBox
            // 
            this.BeginTextBox.Location = new System.Drawing.Point(612, 6);
            this.BeginTextBox.Name = "BeginTextBox";
            this.BeginTextBox.Size = new System.Drawing.Size(100, 20);
            this.BeginTextBox.TabIndex = 2;
            // 
            // EndTextBox
            // 
            this.EndTextBox.Location = new System.Drawing.Point(612, 32);
            this.EndTextBox.Name = "EndTextBox";
            this.EndTextBox.Size = new System.Drawing.Size(100, 20);
            this.EndTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 139);
            this.Controls.Add(this.EndTextBox);
            this.Controls.Add(this.BeginTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AccuracyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.TangentTextBox);
            this.Controls.Add(this.ChordTextBox);
            this.Controls.Add(this.EnterTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnterTextBox;
        private System.Windows.Forms.TextBox ChordTextBox;
        private System.Windows.Forms.TextBox TangentTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AccuracyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BeginTextBox;
        private System.Windows.Forms.TextBox EndTextBox;
    }
}

