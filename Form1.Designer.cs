namespace HotelManagementSystem
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            UsernameFill = new TextBox();
            PasswordFill = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(544, 81);
            label1.Name = "label1";
            label1.Size = new Size(182, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Hotel_Logo;
            pictureBox1.Location = new Point(52, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 334);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(435, 174);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(435, 224);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // UsernameFill
            // 
            UsernameFill.Font = new Font("Helvetica", 11.25F);
            UsernameFill.Location = new Point(531, 172);
            UsernameFill.Name = "UsernameFill";
            UsernameFill.Size = new Size(260, 25);
            UsernameFill.TabIndex = 4;
            // 
            // PasswordFill
            // 
            PasswordFill.Font = new Font("Helvetica", 11.25F);
            PasswordFill.Location = new Point(531, 222);
            PasswordFill.Name = "PasswordFill";
            PasswordFill.Size = new Size(260, 25);
            PasswordFill.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Helvetica", 11F);
            checkBox1.Location = new Point(435, 270);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 21);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Helvetica", 11.25F);
            button1.Location = new Point(684, 307);
            button1.Name = "button1";
            button1.Size = new Size(107, 40);
            button1.TabIndex = 7;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Helvetica", 11.25F);
            button2.Location = new Point(531, 307);
            button2.Name = "button2";
            button2.Size = new Size(107, 40);
            button2.TabIndex = 8;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(527, 361);
            button3.Name = "button3";
            button3.Size = new Size(260, 40);
            button3.TabIndex = 9;
            button3.Text = "Create an account";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(837, 487);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(PasswordFill);
            Controls.Add(UsernameFill);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox UsernameFill;
        private TextBox PasswordFill;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
