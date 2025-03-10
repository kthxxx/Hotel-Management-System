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
    public partial class Gcash : UserControl
    {
        public Gcash()
        {
            InitializeComponent();
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(000000, 1000000); 
            MessageBox.Show($"Your Gcash transaction code is: {randomNumber}", "Transaction Code");
        }


    }
}
