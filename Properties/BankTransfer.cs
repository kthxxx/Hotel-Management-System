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
    public partial class BankTransfer : UserControl
    {
        public BankTransfer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomCode = random.Next(100000, 1000000); 
            MessageBox.Show($"Your bank transfer code is: {randomCode}", "Transfer Code");
        }
    }
}
