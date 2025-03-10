namespace HotelManagementSystem.Properties
{
    partial class AvailableRooms
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            room11 = new Room1();
            room21 = new Room2();
            room31 = new Room3();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(room11);
            flowLayoutPanel1.Controls.Add(room21);
            flowLayoutPanel1.Controls.Add(room31);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(802, 705);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // room11
            // 
            room11.BorderStyle = BorderStyle.FixedSingle;
            room11.Location = new Point(3, 3);
            room11.Name = "room11";
            room11.Size = new Size(795, 220);
            room11.TabIndex = 0;
            // 
            // room21
            // 
            room21.BorderStyle = BorderStyle.FixedSingle;
            room21.Location = new Point(3, 229);
            room21.Name = "room21";
            room21.Size = new Size(795, 220);
            room21.TabIndex = 1;
            // 
            // room31
            // 
            room31.BorderStyle = BorderStyle.FixedSingle;
            room31.Location = new Point(3, 455);
            room31.Name = "room31";
            room31.Size = new Size(795, 220);
            room31.TabIndex = 2;
            // 
            // AvailableRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(flowLayoutPanel1);
            Name = "AvailableRooms";
            Size = new Size(759, 679);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Room1 room11;
        private Room2 room21;
        private Room3 room31;
    }
}
