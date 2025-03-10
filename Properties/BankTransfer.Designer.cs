namespace HotelManagementSystem.Properties
{
    partial class BankTransfer
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
            panel3 = new Panel();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(12, 87, 153);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(537, 17);
            panel3.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Helvetica", 12F);
            label12.Location = new Point(3, 82);
            label12.Name = "label12";
            label12.Size = new Size(266, 19);
            label12.TabIndex = 19;
            label12.Text = "Account Name: Justin Glenn Hingpit";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Helvetica", 12F);
            label10.Location = new Point(3, 60);
            label10.Name = "label10";
            label10.Size = new Size(292, 19);
            label10.TabIndex = 18;
            label10.Text = "Account Number: 4601 8600 6107 3401";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 33);
            label9.Name = "label9";
            label9.Size = new Size(165, 19);
            label9.TabIndex = 17;
            label9.Text = "MetroBank Account";
            // 
            // button1
            // 
            button1.Location = new Point(3, 107);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 20;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 12F);
            label1.Location = new Point(3, 139);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 21;
            label1.Text = "Code:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 22;
            // 
            // BankTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel3);
            Name = "BankTransfer";
            Size = new Size(537, 171);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label label12;
        private Label label10;
        private Label label9;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}
