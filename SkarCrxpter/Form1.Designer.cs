namespace SkarCrxpter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            DownloadUrl = new TextBox();
            label1 = new Label();
            checkBoxObfuscate = new CheckBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            installNameText = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            zeroBomb1 = new CheckBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(426, 211);
            button1.Name = "button1";
            button1.Size = new Size(173, 29);
            button1.TabIndex = 0;
            button1.Text = "Build";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DownloadUrl
            // 
            DownloadUrl.Location = new Point(12, 42);
            DownloadUrl.Name = "DownloadUrl";
            DownloadUrl.Size = new Size(587, 23);
            DownloadUrl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Download Link";
            // 
            // checkBoxObfuscate
            // 
            checkBoxObfuscate.AutoSize = true;
            checkBoxObfuscate.Location = new Point(11, 108);
            checkBoxObfuscate.Name = "checkBoxObfuscate";
            checkBoxObfuscate.Size = new Size(81, 19);
            checkBoxObfuscate.TabIndex = 3;
            checkBoxObfuscate.Text = "Junk Code";
            checkBoxObfuscate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 88);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Code";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "C:\\\\Windows\\\\TEMP\\\\", "%APPDATA%\\\\", "C:\\\\Windows\\\\", "C:\\\\Windows\\\\System32\\\\" });
            comboBox1.Location = new Point(104, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 23);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "C:\\\\Windows\\\\TEMP\\\\";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 88);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 9;
            label3.Text = "Install Path";
            // 
            // installNameText
            // 
            installNameText.Location = new Point(357, 106);
            installNameText.Name = "installNameText";
            installNameText.Size = new Size(242, 23);
            installNameText.TabIndex = 10;
            installNameText.Text = "InstallName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 88);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 11;
            label4.Text = "Install Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 145);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 14;
            label5.Text = "Extra Size";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 170);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 15;
            label6.Text = "kb + 12kb";
            label6.Click += label6_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(104, 162);
            numericUpDown1.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(196, 23);
            numericUpDown1.TabIndex = 16;
            // 
            // zeroBomb1
            // 
            zeroBomb1.AutoSize = true;
            zeroBomb1.Location = new Point(10, 163);
            zeroBomb1.Name = "zeroBomb1";
            zeroBomb1.Size = new Size(82, 19);
            zeroBomb1.TabIndex = 17;
            zeroBomb1.Text = "ZeroBomb";
            zeroBomb1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(326, 217);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Polymorphic";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 252);
            Controls.Add(checkBox1);
            Controls.Add(zeroBomb1);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(installNameText);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(checkBoxObfuscate);
            Controls.Add(label1);
            Controls.Add(DownloadUrl);
            Controls.Add(button1);
            Name = "Form1";
            Text = "SkarCrxpter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox DownloadUrl;
        private Label label1;
        private CheckBox checkBoxObfuscate;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox installNameText;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private CheckBox zeroBomb1;
        private CheckBox checkBox1;
    }
}