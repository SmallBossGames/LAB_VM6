namespace LAB_VM6
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TangentTextBox = new System.Windows.Forms.TextBox();
            this.BeginTextBox = new System.Windows.Forms.TextBox();
            this.EndTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AccuracyTextBox = new System.Windows.Forms.TextBox();
            this.EnterTextBox = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TangentResTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChordResTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TangentItCountTextBox = new System.Windows.Forms.TextBox();
            this.ChordItCountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите значение x (для метода касательных): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите первое значение (для метода хорд): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите второе значение (для метода хорд): ";
            // 
            // TangentTextBox
            // 
            this.TangentTextBox.Location = new System.Drawing.Point(267, 6);
            this.TangentTextBox.Name = "TangentTextBox";
            this.TangentTextBox.Size = new System.Drawing.Size(100, 20);
            this.TangentTextBox.TabIndex = 3;
            // 
            // BeginTextBox
            // 
            this.BeginTextBox.Location = new System.Drawing.Point(255, 30);
            this.BeginTextBox.Name = "BeginTextBox";
            this.BeginTextBox.Size = new System.Drawing.Size(100, 20);
            this.BeginTextBox.TabIndex = 4;
            // 
            // EndTextBox
            // 
            this.EndTextBox.Location = new System.Drawing.Point(254, 56);
            this.EndTextBox.Name = "EndTextBox";
            this.EndTextBox.Size = new System.Drawing.Size(100, 20);
            this.EndTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите точность: ";
            // 
            // AccuracyTextBox
            // 
            this.AccuracyTextBox.Location = new System.Drawing.Point(121, 84);
            this.AccuracyTextBox.Name = "AccuracyTextBox";
            this.AccuracyTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccuracyTextBox.TabIndex = 7;
            // 
            // EnterTextBox
            // 
            this.EnterTextBox.Location = new System.Drawing.Point(373, 6);
            this.EnterTextBox.Name = "EnterTextBox";
            this.EnterTextBox.Size = new System.Drawing.Size(415, 70);
            this.EnterTextBox.TabIndex = 8;
            this.EnterTextBox.Text = "Не знаю, как это назвать, просто жми сюда после ввода данных!";
            this.EnterTextBox.UseVisualStyleBackColor = true;
            this.EnterTextBox.Click += new System.EventHandler(this.EnterTextBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Результат (метод касательных): ";
            // 
            // TangentResTextBox
            // 
            this.TangentResTextBox.Location = new System.Drawing.Point(192, 113);
            this.TangentResTextBox.Name = "TangentResTextBox";
            this.TangentResTextBox.ReadOnly = true;
            this.TangentResTextBox.Size = new System.Drawing.Size(100, 20);
            this.TangentResTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Результат (метод хорд): ";
            // 
            // ChordResTextBox
            // 
            this.ChordResTextBox.Location = new System.Drawing.Point(149, 139);
            this.ChordResTextBox.Name = "ChordResTextBox";
            this.ChordResTextBox.ReadOnly = true;
            this.ChordResTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChordResTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Количество итераций (метод касательных): ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Количество итераций (метод хорд): ";
            // 
            // TangentItCountTextBox
            // 
            this.TangentItCountTextBox.Location = new System.Drawing.Point(535, 113);
            this.TangentItCountTextBox.Name = "TangentItCountTextBox";
            this.TangentItCountTextBox.ReadOnly = true;
            this.TangentItCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.TangentItCountTextBox.TabIndex = 15;
            // 
            // ChordItCountTextBox
            // 
            this.ChordItCountTextBox.Location = new System.Drawing.Point(449, 139);
            this.ChordItCountTextBox.Name = "ChordItCountTextBox";
            this.ChordItCountTextBox.ReadOnly = true;
            this.ChordItCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChordItCountTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 170);
            this.Controls.Add(this.ChordItCountTextBox);
            this.Controls.Add(this.TangentItCountTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChordResTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TangentResTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EnterTextBox);
            this.Controls.Add(this.AccuracyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndTextBox);
            this.Controls.Add(this.BeginTextBox);
            this.Controls.Add(this.TangentTextBox);
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
        private System.Windows.Forms.TextBox TangentTextBox;
        private System.Windows.Forms.TextBox BeginTextBox;
        private System.Windows.Forms.TextBox EndTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AccuracyTextBox;
        private System.Windows.Forms.Button EnterTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TangentResTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ChordResTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TangentItCountTextBox;
        private System.Windows.Forms.TextBox ChordItCountTextBox;
    }
}