using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 menuform = new Form1();
            menuform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 menuform = new Form1();
            menuform.Show();
        }
    }
}
