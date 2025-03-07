namespace HotelManagementSystem.Properties
{
    partial class Room1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Standard_Room;
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 87, 153);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(277, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 40);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 20F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 4);
            label1.Name = "label1";
            label1.Size = new Size(462, 32);
            label1.TabIndex = 0;
            label1.Text = "Garden King Room (Standard Room)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(12, 87, 153);
            label2.Location = new Point(269, 65);
            label2.Name = "label2";
            label2.Size = new Size(477, 17);
            label2.TabIndex = 2;
            label2.Text = " Immerse yourself in nature with a tranquil view of lush, tropical gardens.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(12, 87, 153);
            label3.Location = new Point(269, 84);
            label3.Name = "label3";
            label3.Size = new Size(469, 17);
            label3.TabIndex = 3;
            label3.Text = "These rooms offer a peaceful retreat, bringing the beauty of the resort’s";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(12, 87, 153);
            label4.Location = new Point(269, 103);
            label4.Name = "label4";
            label4.Size = new Size(212, 17);
            label4.TabIndex = 4;
            label4.Text = "greenery right to your doorstep.";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(12, 87, 153);
            button1.Font = new Font("Helvetica", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(587, 164);
            button1.Name = "button1";
            button1.Size = new Size(156, 41);
            button1.TabIndex = 5;
            button1.Text = "BOOK NOW";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(517, 169);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 1;
            label5.Text = "799$";
            // 
            // Room1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Room1";
            Size = new Size(795, 220);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}
