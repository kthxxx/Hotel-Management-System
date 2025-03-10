using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Properties
{
    public partial class Paynow : UserControl
    {
        public Paynow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card cardForm = new Card();
            cardForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(cardForm);
            cardForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gcash gcash = new Gcash();
            gcash.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(gcash);
            gcash.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BankTransfer bankTransfer = new BankTransfer();
            bankTransfer.Dock = DockStyle.Fill;
            panel1.Controls.Clear(); panel1.Controls.Add(bankTransfer);
            bankTransfer.Show();
        }
    }
}
