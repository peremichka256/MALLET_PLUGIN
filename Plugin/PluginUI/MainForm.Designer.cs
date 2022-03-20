namespace PluginUI
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
            this.HeadWidthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HeadHeightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HandleDiameterLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.HeadLengthTextBox = new System.Windows.Forms.TextBox();
            this.HeadHeightTextBox = new System.Windows.Forms.TextBox();
            this.HandleDiameterTextBox = new System.Windows.Forms.TextBox();
            this.HandleHeightTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ChamferRadiusTextBox = new System.Windows.Forms.TextBox();
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
            this.BuildButton.Location = new System.Drawing.Point(15, 305);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(200, 23);
            this.BuildButton.TabIndex = 1;
            this.BuildButton.Text = "Build mallet";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mallet head width(А)";
            // 
            // HeadWidthTextBox
            // 
            this.HeadWidthTextBox.Location = new System.Drawing.Point(172, 12);
            this.HeadWidthTextBox.Name = "HeadWidthTextBox";
            this.HeadWidthTextBox.Size = new System.Drawing.Size(43, 20);
            this.HeadWidthTextBox.TabIndex = 3;
            this.HeadWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.HeadWidthTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "(from 40 to 80 mm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "(from 100 to 200 mm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mallet head length(B)";
            // 
            // HeadHeightLabel
            // 
            this.HeadHeightLabel.AutoSize = true;
            this.HeadHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadHeightLabel.Location = new System.Drawing.Point(12, 127);
            this.HeadHeightLabel.Name = "HeadHeightLabel";
            this.HeadHeightLabel.Size = new System.Drawing.Size(119, 15);
            this.HeadHeightLabel.TabIndex = 8;
            this.HeadHeightLabel.Text = "(from 40 to 100 mm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mallet head height(С)";
            // 
            // HandleDiameterLabel
            // 
            this.HandleDiameterLabel.AutoSize = true;
            this.HandleDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HandleDiameterLabel.Location = new System.Drawing.Point(12, 177);
            this.HandleDiameterLabel.Name = "HandleDiameterLabel";
            this.HandleDiameterLabel.Size = new System.Drawing.Size(112, 15);
            this.HandleDiameterLabel.TabIndex = 10;
            this.HandleDiameterLabel.Text = "(from 20 to 70 mm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mallet handle diameter(D)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "(from 150 to 400 mm)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mallet handle height(H)";
            // 
            // HeadLengthTextBox
            // 
            this.HeadLengthTextBox.Location = new System.Drawing.Point(172, 62);
            this.HeadLengthTextBox.Name = "HeadLengthTextBox";
            this.HeadLengthTextBox.Size = new System.Drawing.Size(43, 20);
            this.HeadLengthTextBox.TabIndex = 13;
            this.HeadLengthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.HeadLengthTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // HeadHeightTextBox
            // 
            this.HeadHeightTextBox.Location = new System.Drawing.Point(172, 112);
            this.HeadHeightTextBox.Name = "HeadHeightTextBox";
            this.HeadHeightTextBox.Size = new System.Drawing.Size(43, 20);
            this.HeadHeightTextBox.TabIndex = 14;
            this.HeadHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.HeadHeightTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // HandleDiameterTextBox
            // 
            this.HandleDiameterTextBox.Location = new System.Drawing.Point(172, 162);
            this.HandleDiameterTextBox.Name = "HandleDiameterTextBox";
            this.HandleDiameterTextBox.Size = new System.Drawing.Size(43, 20);
            this.HandleDiameterTextBox.TabIndex = 15;
            this.HandleDiameterTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.HandleDiameterTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // HandleHeightTextBox
            // 
            this.HandleHeightTextBox.Location = new System.Drawing.Point(172, 212);
            this.HandleHeightTextBox.Name = "HandleHeightTextBox";
            this.HandleHeightTextBox.Size = new System.Drawing.Size(43, 20);
            this.HandleHeightTextBox.TabIndex = 16;
            this.HandleHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.HandleHeightTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "Input error";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Chamfer size on head(F)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "(from 1 to 4 mm)";
            // 
            // ChamferRadiusTextBox
            // 
            this.ChamferRadiusTextBox.Location = new System.Drawing.Point(172, 262);
            this.ChamferRadiusTextBox.Name = "ChamferRadiusTextBox";
            this.ChamferRadiusTextBox.Size = new System.Drawing.Size(43, 20);
            this.ChamferRadiusTextBox.TabIndex = 19;
            this.ChamferRadiusTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.ChamferRadiusTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 428);
            this.Controls.Add(this.ChamferRadiusTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.HandleHeightTextBox);
            this.Controls.Add(this.HandleDiameterTextBox);
            this.Controls.Add(this.HeadHeightTextBox);
            this.Controls.Add(this.HeadLengthTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.HandleDiameterLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HeadHeightLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeadWidthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.MalletParametersPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Mallet building in KOMPAS-3D";
            ((System.ComponentModel.ISupportInitialize)(this.MalletParametersPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MalletParametersPictureBox;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HeadWidthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HeadHeightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label HandleDiameterLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox HeadLengthTextBox;
        private System.Windows.Forms.TextBox HeadHeightTextBox;
        private System.Windows.Forms.TextBox HandleDiameterTextBox;
        private System.Windows.Forms.TextBox HandleHeightTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ChamferRadiusTextBox;
    }
}

