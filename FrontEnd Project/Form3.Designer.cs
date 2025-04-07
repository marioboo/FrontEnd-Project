namespace FrontEnd_Project
{
    partial class Form3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            fullName = new TextBox();
            agE = new TextBox();
            emailAddress = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            genDer = new ComboBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label8 = new Label();
            button2 = new Button();
            label9 = new Label();
            birthDay = new DateTimePicker();
            label10 = new Label();
            comboBox2 = new ComboBox();
            SecurityAnswer = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label1.Location = new Point(365, 121);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label2.Location = new Point(365, 275);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 1;
            label2.Text = "Email address: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label3.Location = new Point(366, 157);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label4.Location = new Point(366, 235);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 3;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label5.Location = new Point(365, 388);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 4;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label6.Location = new Point(365, 426);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 5;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label7.Location = new Point(365, 463);
            label7.Name = "label7";
            label7.Size = new Size(179, 21);
            label7.TabIndex = 6;
            label7.Text = "Confirm Password:";
            // 
            // fullName
            // 
            fullName.Location = new Point(568, 115);
            fullName.Name = "fullName";
            fullName.Size = new Size(216, 27);
            fullName.TabIndex = 7;
            fullName.TextChanged += fullName_TextChanged;
            // 
            // agE
            // 
            agE.Location = new Point(568, 155);
            agE.Name = "agE";
            agE.Size = new Size(216, 27);
            agE.TabIndex = 8;
            agE.TextChanged += agE_TextChanged;
            // 
            // emailAddress
            // 
            emailAddress.Location = new Point(567, 275);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(216, 27);
            emailAddress.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(568, 388);
            textBox5.MaxLength = 10;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(216, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(566, 426);
            textBox6.MaxLength = 10;
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(216, 27);
            textBox6.TabIndex = 12;
            // 
            // genDer
            // 
            genDer.FormattingEnabled = true;
            genDer.Items.AddRange(new object[] { "Male", "Female" });
            genDer.Location = new Point(567, 233);
            genDer.Name = "genDer";
            genDer.Size = new Size(216, 28);
            genDer.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(565, 463);
            textBox3.MaxLength = 10;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(216, 27);
            textBox3.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(486, 547);
            button1.Name = "button1";
            button1.Size = new Size(216, 32);
            button1.TabIndex = 15;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(128, 64, 64);
            label8.Location = new Point(311, 53);
            label8.Name = "label8";
            label8.Size = new Size(539, 54);
            label8.TabIndex = 16;
            label8.Text = "Register Your Account";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(15, 19);
            button2.Name = "button2";
            button2.Size = new Size(88, 36);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label9.Location = new Point(366, 196);
            label9.Name = "label9";
            label9.Size = new Size(91, 21);
            label9.TabIndex = 18;
            label9.Text = "Birthday:";
            // 
            // birthDay
            // 
            birthDay.Format = DateTimePickerFormat.Custom;
            birthDay.Location = new Point(568, 196);
            birthDay.Name = "birthDay";
            birthDay.Size = new Size(215, 27);
            birthDay.TabIndex = 19;
            birthDay.Value = new DateTime(2025, 3, 10, 0, 0, 0, 0);
            birthDay.ValueChanged += birthDay_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label10.Location = new Point(365, 314);
            label10.Name = "label10";
            label10.Size = new Size(174, 21);
            label10.TabIndex = 20;
            label10.Text = "Security Question:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownWidth = 300;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "What was the name of your first pet?", "What is your mother’s maiden name?", "In what city were you born?", "What was your childhood nickname?v", "What was the name of your first school?", "What was your favorite subject in school?", "What is your favorite movie?", "What is your favorite food?" });
            comboBox2.Location = new Point(567, 314);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(214, 28);
            comboBox2.TabIndex = 21;
            // 
            // SecurityAnswer
            // 
            SecurityAnswer.Location = new Point(566, 352);
            SecurityAnswer.Name = "SecurityAnswer";
            SecurityAnswer.PasswordChar = '*';
            SecurityAnswer.Size = new Size(217, 27);
            SecurityAnswer.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label11.Location = new Point(366, 352);
            label11.Name = "label11";
            label11.Size = new Size(84, 21);
            label11.TabIndex = 23;
            label11.Text = "Answer:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1104, 617);
            Controls.Add(label11);
            Controls.Add(SecurityAnswer);
            Controls.Add(comboBox2);
            Controls.Add(label10);
            Controls.Add(birthDay);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(genDer);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(emailAddress);
            Controls.Add(agE);
            Controls.Add(fullName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox fullName;
        private TextBox agE;
        private TextBox emailAddress;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox genDer;
        private TextBox textBox3;
        private TextBox textBox7;
        private Button button1;
        private Label label8;
        private Button button2;
        private Label label9;
        private DateTimePicker birthDay;
        private Label label10;
        private ComboBox comboBox2;
        private TextBox SecurityAnswer;
        private Label label11;
    }
}