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
    public partial class ManagementPage : Form
    {
        public ManagementPage()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void buttonFoodmng_Click(object sender, EventArgs e)
        {
            this.Hide();

           
            //new Prisoner().Show();
            new Foods().Show();
        }

        private void buttonmngprsnr_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Prisoner().Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void ManagementPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
