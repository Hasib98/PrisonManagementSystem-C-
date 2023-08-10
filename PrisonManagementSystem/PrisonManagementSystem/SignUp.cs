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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public string Getpath()
        {
            string path = Environment.CurrentDirectory;
            path = path.TrimEnd(new Char[] { 'b', 'i', 'n', '\\', 'D', 'e', 'b', 'u', 'g' });
            path = path + "\\Database\\PrisonManagementSystem.mdf";
            return path;
        }


        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Getpath()+";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Name FROM Login WHERE Name LIKE '%" + textName.Text + "%'", con);
            DataTable ds = new DataTable();
            sda.Fill(ds);

                if (isValid())
                {
                    if (ds.Rows.Count >= 1)
                    {
                        MessageBox.Show("User Name already Exist", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                    }
                    else
                    {
                        if (textPassword.Text == textConfirmPassword.Text)
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Login VALUES (@Name,@Password)", con);
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Name", textName.Text);
                            cmd.Parameters.AddWithValue("@Password", textPassword.Text);

                            con.Open();
                            cmd.ExecuteNonQuery();

                            string Id;
                            //MessageBox.Show("New User Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string keyword = textName.Text;
                            String sqlSelectQuery = "SELECT * FROM Login WHERE Name LIKE '%" + keyword + "%'";
                            SqlCommand comm = new SqlCommand(sqlSelectQuery, con);
                            SqlDataReader sdr = comm.ExecuteReader();
                            if (sdr.Read())
                            {
                                Id = (sdr["Id"].ToString());
                                MessageBox.Show("Your user  Id is " + Id, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            con.Close();
                            Reset();
                        }
                        else
                        {
                            MessageBox.Show("Password do not match", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Reset();
                        }
                    }
                }
        }
        private bool isValid()
        {
            if (textName.Text == string.Empty || textPassword.Text==string.Empty || textConfirmPassword.Text==string.Empty)
            {
                MessageBox.Show("All details are required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                return false;
            }
            return true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new Home().Show();
            new UserHome().Show();
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
                textConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
                textConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void textConfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (textPassword.Text == textConfirmPassword.Text)
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
        public void Reset()
        {
            textName.Text = "";
            textPassword.Text = "";
            textConfirmPassword.Text = "";
            textName.Focus();
        }

        private void labelConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            labelName.Parent = pictureBox1;
            labelName.BackColor = System.Drawing.Color.Transparent;

            labelPassword.Parent = pictureBox1;
            labelPassword.BackColor = System.Drawing.Color.Transparent;

            labelConfirmPassword.Parent = pictureBox1;
            labelConfirmPassword.BackColor = System.Drawing.Color.Transparent;

            labelSignUp.Parent = pictureBox1;
            labelSignUp.BackColor = System.Drawing.Color.Transparent;

            checkBoxShowPassword.Parent = pictureBox1;
            checkBoxShowPassword.BackColor = System.Drawing.Color.Transparent;

            

            

            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

