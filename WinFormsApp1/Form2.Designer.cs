﻿namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(257, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 54);
            label1.TabIndex = 1;
            label1.Text = "Регистрация";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(257, 302);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(257, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 27);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 27);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(118, 199);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 8;
            label3.Text = "Пароль:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(118, 141);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 7;
            label2.Text = "Логин:";
            // 
            // button1
            // 
            button1.Location = new Point(257, 344);
            button1.Name = "button1";
            button1.Size = new Size(261, 66);
            button1.TabIndex = 12;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(257, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 27);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(118, 269);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 13;
            label4.Text = "ФИО:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox textBox3;
        private Label label4;
    }
}