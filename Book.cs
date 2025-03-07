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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPage menuform = new LandingPage();
            menuform.Show();
        }
    }
}
