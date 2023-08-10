using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHome().Show();
        }
        public string Getpath()
        {
            string path = Environment.CurrentDirectory;
            path = path.TrimEnd(new Char[] { 'b', 'i', 'n', '\\', 'D', 'e', 'b', 'u', 'g' });
            path = path + "\\Database\\PrisonManagementSystem.mdf";
            return path;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Getpath()+";Integrated Security=True;Connect Timeout=30"); // making connection   
            int result;
            if (int.TryParse(textId.Text, out result)) 
            { 
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Login WHERE Id='" + textId.Text + "' AND Password='" + textPassword.Text + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();

                    new ManagementPage().Show();
                    //new Prisoner().Show();
                    //new Foods().Show();
                }
                else
                    MessageBox.Show("Invalid Id or Password", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Invalid Id", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePassword().Show();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = System.Drawing.Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = System.Drawing.Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = System.Drawing.Color.Transparent;

            checkBoxShowPassword.Parent = pictureBox1;
            checkBoxShowPassword.BackColor = System.Drawing.Color.Transparent;

            //checkBoxShowPassword.Parent = pictureBox1;
            //checkBoxShowPassword.BackColor = System.Drawing.Color.Transparent;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

