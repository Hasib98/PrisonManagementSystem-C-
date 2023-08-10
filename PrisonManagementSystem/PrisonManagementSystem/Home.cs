using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
