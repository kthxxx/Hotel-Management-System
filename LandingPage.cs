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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome menuform = new Welcome();
            menuform.Show();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book book = new Book();
            book.Show();
        }

        private void GalleryBtn_MouseHover(object sender, EventArgs e)
        {
            Label button = sender as Label;
            if (button != null)
            {
                button.ForeColor = Color.FromArgb(12, 87, 153);
            }
        }

        private void GalleryBtn_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void ResortBtn_MouseHover(object sender, EventArgs e)
        {
            Label button = sender as Label;
            if (button != null)
            {
                button.ForeColor = Color.FromArgb(12, 87, 153);
            }
        }

        private void ResortBtn_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }
    }
}
