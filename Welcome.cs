namespace HotelManagementSystem
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            SignUp menuform = new SignUp();
            menuform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;

            username = UsernameFill.Text;
            password = PasswordFill.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = UsernameFill.Text;
            string password = PasswordFill.Text;

            UsernameFill.Text = string.Empty;
            PasswordFill.Text = string.Empty;

        }

    }
}
