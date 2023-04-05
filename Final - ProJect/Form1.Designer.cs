namespace Final___ProJect
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbName = new TextBox();
            tbPayment = new TextBox();
            tbType = new TextBox();
            tbIdBook = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "BookName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 48);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Type :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 77);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "ID Book :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 106);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Payment :";
            // 
            // tbName
            // 
            tbName.Location = new Point(94, 16);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 0;
            tbName.TextChanged += textBox1_TextChanged;
            // 
            // tbPayment
            // 
            tbPayment.Location = new Point(94, 103);
            tbPayment.Name = "tbPayment";
            tbPayment.Size = new Size(100, 23);
            tbPayment.TabIndex = 3;
            tbPayment.TextChanged += textBox2_TextChanged;
            // 
            // tbType
            // 
            tbType.Location = new Point(94, 45);
            tbType.Name = "tbType";
            tbType.Size = new Size(100, 23);
            tbType.TabIndex = 1;
            tbType.TextChanged += textBox3_TextChanged;
            // 
            // tbIdBook
            // 
            tbIdBook.Location = new Point(94, 74);
            tbIdBook.Name = "tbIdBook";
            tbIdBook.Size = new Size(100, 23);
            tbIdBook.TabIndex = 2;
            tbIdBook.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(34, 22);
            button1.Name = "button1";
            button1.Size = new Size(143, 23);
            button1.TabIndex = 0;
            button1.Text = "Manga";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(34, 80);
            button2.Name = "button2";
            button2.Size = new Size(143, 23);
            button2.TabIndex = 2;
            button2.Text = "Learning";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(34, 51);
            button3.Name = "button3";
            button3.Size = new Size(143, 23);
            button3.TabIndex = 1;
            button3.Text = "LightNovel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(34, 109);
            button4.Name = "button4";
            button4.Size = new Size(143, 23);
            button4.TabIndex = 3;
            button4.Text = "Traveling";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbType);
            groupBox1.Controls.Add(tbIdBook);
            groupBox1.Controls.Add(tbPayment);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(218, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 134);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data's Book";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(218, 154);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 142);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Type's Book";
            // 
            // button5
            // 
            button5.Location = new Point(12, 302);
            button5.Name = "button5";
            button5.Size = new Size(200, 37);
            button5.TabIndex = 0;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(218, 302);
            button6.Name = "button6";
            button6.Size = new Size(200, 37);
            button6.TabIndex = 1;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(444, 346);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox tbName;
        private TextBox tbPayment;
        private TextBox tbType;
        private TextBox tbIdBook;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button button5;
        private Button button6;
    }
}