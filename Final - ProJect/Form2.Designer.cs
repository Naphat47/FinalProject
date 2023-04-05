namespace Final___ProJect
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbIDCard = new TextBox();
            tbLName = new TextBox();
            tbFName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(tbIDCard);
            groupBox1.Controls.Add(tbLName);
            groupBox1.Controls.Add(tbFName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 231);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data's User";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(109, 185);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 10;
            button1.Text = "finish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(109, 156);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(100, 23);
            tbEmail.TabIndex = 9;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(109, 127);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(100, 23);
            tbPhone.TabIndex = 8;
            // 
            // tbIDCard
            // 
            tbIDCard.Location = new Point(109, 98);
            tbIDCard.Name = "tbIDCard";
            tbIDCard.Size = new Size(100, 23);
            tbIDCard.TabIndex = 7;
            // 
            // tbLName
            // 
            tbLName.Location = new Point(109, 68);
            tbLName.Name = "tbLName";
            tbLName.Size = new Size(100, 23);
            tbLName.TabIndex = 6;
            // 
            // tbFName
            // 
            tbFName.Location = new Point(109, 37);
            tbFName.Name = "tbFName";
            tbFName.Size = new Size(100, 23);
            tbFName.TabIndex = 5;
            tbFName.TextChanged += tbFName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(61, 159);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(56, 130);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 101);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Id Card :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 71);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(284, 254);
            Controls.Add(groupBox1);
            ForeColor = Color.FromArgb(192, 192, 255);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbIDCard;
        private TextBox tbLName;
        private TextBox tbFName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}