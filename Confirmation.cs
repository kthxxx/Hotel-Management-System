using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Properties;

namespace HotelManagementSystem
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paynow paynow = new Paynow();
            paynow.Dock = DockStyle.Fill;
            panel7.Controls.Clear();
            panel7.Controls.Add(paynow);
            paynow.Show();
        }
    }
}
