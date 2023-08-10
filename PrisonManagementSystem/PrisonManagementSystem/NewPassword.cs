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
    public partial class NewPassword : Form
    {
        ChangePassword cg;
        public NewPassword(ChangePassword CG)
        {
            InitializeComponent();
            this.cg = CG;
        }
        public string Getpaths()
        {
            string path = Environment.CurrentDirectory;
            path = path.TrimEnd(new Char[] { 'b', 'i', 'n', '\\', 'D', 'e', 'b', 'u', 'g' });
            path = path + "\\Database\\PrisonManagementSystem.mdf";
            return path;
        }
        private void NewPassword_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = System.Drawing.Color.Transparent;

            labelConfirmPassword.Parent = pictureBox1;
            labelConfirmPassword.BackColor = System.Drawing.Color.Transparent;

            labelId.Parent = pictureBox1;
            labelId.BackColor = System.Drawing.Color.Transparent;

            labelMsg.Parent = pictureBox1;
            labelMsg.BackColor = System.Drawing.Color.Transparent;

            labelNewPassword.Parent = pictureBox1;
            labelNewPassword.BackColor = System.Drawing.Color.Transparent;

            checkShowPassword.Parent = pictureBox1;
            checkShowPassword.BackColor = System.Drawing.Color.Transparent;



            textId.Text = cg.textId.Text;
        }
        private bool isValid()
        {
            if (textNewPassword.Text == string.Empty || textConfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("All details are required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (textNewPassword.Text == textConfirmPassword.Text)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Getpaths() + ";Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand("UPDATE Login SET Password=@Password WHERE Id='" + textId.Text + "'", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Password", textConfirmPassword.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Password Updated", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Login().Show();
                }
                else
                {
                    MessageBox.Show("Password do not match", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textConfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (textNewPassword.Text == textConfirmPassword.Text)
            {
                labelMsg.Text = "Matched";
                labelMsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelMsg.Text = "Not Matched";
                labelMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
            {
                textNewPassword.UseSystemPasswordChar = false;
                textConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textNewPassword.UseSystemPasswordChar = true;
                textConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnaBackFoodFrame_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePassword().Show();
        }

        private void NewPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
