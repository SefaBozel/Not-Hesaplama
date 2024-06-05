namespace arac
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 61);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "İsim Soyisim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci No.:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 192, 255);
            textBox1.Location = new Point(105, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 192, 255);
            textBox2.Location = new Point(105, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 192, 255);
            textBox3.Location = new Point(82, 176);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(52, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Vize-1";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(255, 192, 255);
            textBox4.Location = new Point(229, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(52, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 179);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 6;
            label4.Text = "Vize-2";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(255, 192, 255);
            textBox5.Location = new Point(410, 176);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(52, 27);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 179);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 8;
            label5.Text = "Final";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.FromArgb(128, 64, 64);
            button1.Location = new Point(133, 226);
            button1.Name = "button1";
            button1.Size = new Size(239, 59);
            button1.TabIndex = 10;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 192, 255);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(9, 308);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(553, 204);
            listBox1.TabIndex = 12;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(574, 534);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
    }
}