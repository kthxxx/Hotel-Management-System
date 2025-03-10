namespace HotelManagementSystem
{
    partial class Book
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
            panel1 = new Panel();
            label2 = new Label();
            GalleryBtn = new Label();
            ResortBtn = new Label();
            LogoBtn = new PictureBox();
            label1 = new Label();
            ExitBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            CheckRoomBtn = new Button();
            AvailableRoomPnl = new FlowLayoutPanel();
            label10 = new Label();
            panel5 = new Panel();
            label12 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBtn).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(GalleryBtn);
            panel1.Controls.Add(ResortBtn);
            panel1.Controls.Add(LogoBtn);
            panel1.Location = new Point(3, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 83);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1012, 30);
            label2.Name = "label2";
            label2.Size = new Size(168, 22);
            label2.TabIndex = 5;
            label2.Text = "+63 929 517 4467";
            // 
            // GalleryBtn
            // 
            GalleryBtn.AutoSize = true;
            GalleryBtn.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GalleryBtn.Location = new Point(595, 30);
            GalleryBtn.Name = "GalleryBtn";
            GalleryBtn.Size = new Size(100, 22);
            GalleryBtn.TabIndex = 4;
            GalleryBtn.Text = "GALLERY";
            // 
            // ResortBtn
            // 
            ResortBtn.AutoSize = true;
            ResortBtn.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResortBtn.Location = new Point(457, 30);
            ResortBtn.Name = "ResortBtn";
            ResortBtn.Size = new Size(91, 22);
            ResortBtn.TabIndex = 3;
            ResortBtn.Text = "RESORT";
            // 
            // LogoBtn
            // 
            LogoBtn.Image = Properties.Resources.Hotel_Logo;
            LogoBtn.Location = new Point(0, 0);
            LogoBtn.Name = "LogoBtn";
            LogoBtn.Size = new Size(100, 83);
            LogoBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBtn.TabIndex = 2;
            LogoBtn.TabStop = false;
            LogoBtn.Click += LogoBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 87, 153);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(269, 32);
            label1.TabIndex = 5;
            label1.Text = "THE LAST RESORT";
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = SystemColors.Control;
            ExitBtn.Location = new Point(1202, 5);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(32, 28);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "X";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(184, 54);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 26);
            dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 25);
            label3.Name = "label3";
            label3.Size = new Size(123, 17);
            label3.TabIndex = 7;
            label3.Text = "CHECK IN DATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(508, 25);
            label4.Name = "label4";
            label4.Size = new Size(140, 17);
            label4.TabIndex = 9;
            label4.Text = "CHECK OUT DATE";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(508, 54);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(293, 26);
            dateTimePicker2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(178, 7);
            label5.Name = "label5";
            label5.Size = new Size(235, 25);
            label5.TabIndex = 10;
            label5.Text = "GUEST INFORMATION";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(3, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(1231, 128);
            panel2.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(12, 87, 153);
            button1.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(660, 53);
            button1.Name = "button1";
            button1.Size = new Size(226, 47);
            button1.TabIndex = 11;
            button1.Text = "SAVE INFORMATION";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(250, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(373, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 23);
            textBox1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(184, 96);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
            label8.TabIndex = 14;
            label8.Text = "EMAIL:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(184, 69);
            label7.Name = "label7";
            label7.Size = new Size(85, 17);
            label7.TabIndex = 13;
            label7.Text = "ADDRESS:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(184, 43);
            label6.Name = "label6";
            label6.Size = new Size(60, 17);
            label6.TabIndex = 12;
            label6.Text = "NAME: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Helvetica", 30F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(458, 9);
            label9.Name = "label9";
            label9.Size = new Size(303, 47);
            label9.TabIndex = 12;
            label9.Text = "RESERVATION";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(12, 87, 153);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(3, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(1231, 72);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(CheckRoomBtn);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Location = new Point(4, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(1230, 110);
            panel4.TabIndex = 14;
            // 
            // CheckRoomBtn
            // 
            CheckRoomBtn.BackColor = Color.FromArgb(12, 87, 153);
            CheckRoomBtn.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckRoomBtn.ForeColor = SystemColors.Control;
            CheckRoomBtn.Location = new Point(823, 27);
            CheckRoomBtn.Name = "CheckRoomBtn";
            CheckRoomBtn.Size = new Size(273, 47);
            CheckRoomBtn.TabIndex = 10;
            CheckRoomBtn.Text = "CHECK AVAILABLE ROOMS";
            CheckRoomBtn.UseVisualStyleBackColor = false;
            CheckRoomBtn.Click += CheckRoomBtn_Click;
            // 
            // AvailableRoomPnl
            // 
            AvailableRoomPnl.AutoScroll = true;
            AvailableRoomPnl.BorderStyle = BorderStyle.Fixed3D;
            AvailableRoomPnl.Location = new Point(182, 496);
            AvailableRoomPnl.Name = "AvailableRoomPnl";
            AvailableRoomPnl.Size = new Size(828, 382);
            AvailableRoomPnl.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Helvetica", 30F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(12, 87, 153);
            label10.Location = new Point(445, 446);
            label10.Name = "label10";
            label10.Size = new Size(303, 47);
            label10.TabIndex = 13;
            label10.Text = "RESERVATION";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 31, 32);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(-8, 925);
            panel5.Name = "panel5";
            panel5.Size = new Size(1242, 186);
            panel5.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Helvetica", 11F);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(371, 141);
            label12.Name = "label12";
            label12.Size = new Size(527, 17);
            label12.TabIndex = 8;
            label12.Text = "Jun Mark Manos | Keith Justin Emeterio | Junex Glenn Baran | Christian Hingpit";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Helvetica", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(234, 109);
            label11.Name = "label11";
            label11.Size = new Size(806, 25);
            label11.TabIndex = 7;
            label11.Text = "The Last Resort |100-1, Kahumayan St., Bahay, Sibonga, Cebu | +63 929 517 4467";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LANDSCAPELOGO;
            pictureBox1.Location = new Point(419, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1251, 695);
            Controls.Add(panel5);
            Controls.Add(label10);
            Controls.Add(AvailableRoomPnl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(ExitBtn);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label GalleryBtn;
        private Label ResortBtn;
        private PictureBox LogoBtn;
        private Label label1;
        private Button ExitBtn;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
        private Panel panel3;
        private Panel panel4;
        private FlowLayoutPanel AvailableRoomPnl;
        private Label label10;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label12;
        private Button CheckRoomBtn;
        private Button button1;
    }
}