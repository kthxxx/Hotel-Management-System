namespace HotelManagementSystem
{
    partial class SignUp
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            ExitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Hotel_Logo;
            pictureBox1.Location = new Point(52, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 334);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(477, 67);
            label1.Name = "label1";
            label1.Size = new Size(291, 45);
            label1.TabIndex = 3;
            label1.Text = "Create Account";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Helvetica", 11.25F);
            textBox2.Location = new Point(522, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 25);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Helvetica", 11.25F);
            textBox1.Location = new Point(522, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 25);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(426, 217);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(418, 167);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Helvetica", 11.25F);
            textBox3.Location = new Point(522, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 25);
            textBox3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(367, 269);
            label4.Name = "label4";
            label4.Size = new Size(136, 19);
            label4.TabIndex = 10;
            label4.Text = "Repeat Password";
            // 
            // button2
            // 
            button2.Font = new Font("Helvetica", 11.25F);
            button2.Location = new Point(661, 327);
            button2.Name = "button2";
            button2.Size = new Size(107, 40);
            button2.TabIndex = 12;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Helvetica", 11.25F);
            button1.Location = new Point(522, 327);
            button1.Name = "button1";
            button1.Size = new Size(107, 40);
            button1.TabIndex = 13;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = SystemColors.Control;
            ExitBtn.Location = new Point(797, 5);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(32, 28);
            ExitBtn.TabIndex = 14;
            ExitBtn.Text = "X";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 487);
            Controls.Add(ExitBtn);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private Button button2;
        private Button button1;
        private Button ExitBtn;
    }
}