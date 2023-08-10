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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
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

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Getpath() + ";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Login WHERE Id='" + textId.Text + "' AND Name='" + textName.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
                {
                    string keyword = textCurrentPassword.Text;
                    string password;
                    String sqlSelectQuery = "SELECT * FROM Login WHERE Id LIKE '%" + textId.Text + "%' AND Name LIKE '%" + textName.Text + "%'";
                    SqlCommand comm = new SqlCommand(sqlSelectQuery, con);
                    con.Open();
                    SqlDataReader sdr = comm.ExecuteReader();
                    if (sdr.Read())
                        {
                            password = (sdr["Password"].ToString());
                            if (keyword == password)
                            {
                                //MessageBox.Show("Matched", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                NewPassword np = new NewPassword(this);
                                np.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Request not processed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        con.Close();
                    }
             else
             {
                MessageBox.Show("Request not processed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

        }

        private void textCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textCurrentPassword_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            label5.Parent = pictureBox1;
            label5.BackColor = System.Drawing.Color.Transparent;

            labelId.Parent = pictureBox1;
            labelId.BackColor = System.Drawing.Color.Transparent;

            labelUserName.Parent = pictureBox1;
            labelUserName.BackColor = System.Drawing.Color.Transparent;

            labelCurrentPassword.Parent = pictureBox1;
            labelCurrentPassword.BackColor = System.Drawing.Color.Transparent;


            checkShowPassword.Parent = pictureBox1;
            checkShowPassword.BackColor = System.Drawing.Color.Transparent;




        }

        private void textId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 46 && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
            {
                textCurrentPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textCurrentPassword.UseSystemPasswordChar = true;
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
