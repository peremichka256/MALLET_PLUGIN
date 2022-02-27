﻿namespace PluginUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MalletParametersPictureBox = new System.Windows.Forms.PictureBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HandleDiameterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.HeadHeightTextBox = new System.Windows.Forms.TextBox();
            this.HeadLengthTextBox = new System.Windows.Forms.TextBox();
            this.HeadWidthTextBox = new System.Windows.Forms.TextBox();
            this.HandleHeightTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MalletParametersPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MalletParametersPictureBox
            // 
            this.MalletParametersPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MalletParametersPictureBox.Image")));
            this.MalletParametersPictureBox.Location = new System.Drawing.Point(230, 12);
            this.MalletParametersPictureBox.Name = "MalletParametersPictureBox";
            this.MalletParametersPictureBox.Size = new System.Drawing.Size(204, 407);
            this.MalletParametersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MalletParametersPictureBox.TabIndex = 0;
            this.MalletParametersPictureBox.TabStop = false;
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(15, 262);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(200, 23);
            this.BuildButton.TabIndex = 1;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ширина бойка киянки(А)";
            // 
            // HandleDiameterTextBox
            // 
            this.HandleDiameterTextBox.Location = new System.Drawing.Point(172, 162);
            this.HandleDiameterTextBox.Name = "HandleDiameterTextBox";
            this.HandleDiameterTextBox.Size = new System.Drawing.Size(43, 20);
            this.HandleDiameterTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "(от 40 до 80 мм)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "(от 100 до 200 мм)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Длина бойка киянки(B)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "(от 40 до B/2 мм)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Высота бойка киянки(С)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "(от 20 до A-10 мм)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Диаметр ручки киянки(D)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "(от 150 до 400 мм)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Высота ручки киянки(H)";
            // 
            // HeadHeightTextBox
            // 
            this.HeadHeightTextBox.Location = new System.Drawing.Point(172, 112);
            this.HeadHeightTextBox.Name = "HeadHeightTextBox";
            this.HeadHeightTextBox.Size = new System.Drawing.Size(43, 20);
            this.HeadHeightTextBox.TabIndex = 13;
            // 
            // HeadLengthTextBox
            // 
            this.HeadLengthTextBox.Location = new System.Drawing.Point(172, 62);
            this.HeadLengthTextBox.Name = "HeadLengthTextBox";
            this.HeadLengthTextBox.Size = new System.Drawing.Size(43, 20);
            this.HeadLengthTextBox.TabIndex = 14;
            // 
            // HeadWidthTextBox
            // 
            this.HeadWidthTextBox.Location = new System.Drawing.Point(172, 12);
            this.HeadWidthTextBox.Name = "HeadWidthTextBox";
            this.HeadWidthTextBox.Size = new System.Drawing.Size(43, 20);
            this.HeadWidthTextBox.TabIndex = 15;
            // 
            // HandleHeightTextBox
            // 
            this.HandleHeightTextBox.Location = new System.Drawing.Point(172, 212);
            this.HandleHeightTextBox.Name = "HandleHeightTextBox";
            this.HandleHeightTextBox.Size = new System.Drawing.Size(43, 20);
            this.HandleHeightTextBox.TabIndex = 16;
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "Ошибка ввода";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 428);
            this.Controls.Add(this.HandleHeightTextBox);
            this.Controls.Add(this.HeadWidthTextBox);
            this.Controls.Add(this.HeadLengthTextBox);
            this.Controls.Add(this.HeadHeightTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HandleDiameterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.MalletParametersPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Построение киянки в КОМПАС-3D";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MalletParametersPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MalletParametersPictureBox;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HandleDiameterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox HeadHeightTextBox;
        private System.Windows.Forms.TextBox HeadLengthTextBox;
        private System.Windows.Forms.TextBox HeadWidthTextBox;
        private System.Windows.Forms.TextBox HandleHeightTextBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

