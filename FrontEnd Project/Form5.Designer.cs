namespace FrontEnd_Project
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
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label10 = new Label();
            SecurityAnswer = new TextBox();
            label11 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 92);
            label1.Name = "label1";
            label1.Size = new Size(320, 39);
            label1.TabIndex = 0;
            label1.Text = "Forgot Password?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 168);
            label2.Name = "label2";
            label2.Size = new Size(741, 27);
            label2.TabIndex = 1;
            label2.Text = "Answer one question you chose when your account was created.";
            label2.Click += label2_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownWidth = 300;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "What was the name of your first pet?", "What is your mother’s maiden name?", "In what city were you born?", "What was your childhood nickname?v", "What was the name of your first school?", "What was your favorite subject in school?", "What is your favorite movie?", "What is your favorite food?" });
            comboBox2.Location = new Point(469, 256);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(214, 28);
            comboBox2.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label10.Location = new Point(278, 258);
            label10.Name = "label10";
            label10.Size = new Size(174, 21);
            label10.TabIndex = 23;
            label10.Text = "Security Question:";
            // 
            // SecurityAnswer
            // 
            SecurityAnswer.Location = new Point(469, 310);
            SecurityAnswer.Name = "SecurityAnswer";
            SecurityAnswer.PasswordChar = '*';
            SecurityAnswer.Size = new Size(217, 27);
            SecurityAnswer.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label11.Location = new Point(318, 316);
            label11.Name = "label11";
            label11.Size = new Size(84, 21);
            label11.TabIndex = 25;
            label11.Text = "Answer:";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(34, 30);
            button2.Name = "button2";
            button2.Size = new Size(88, 36);
            button2.TabIndex = 26;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(505, 382);
            button1.Name = "button1";
            button1.Size = new Size(88, 36);
            button1.TabIndex = 27;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1119, 616);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(SecurityAnswer);
            Controls.Add(label10);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label10;
        private TextBox SecurityAnswer;
        private Label label11;
        private Button button2;
        private Button button1;
    }
}