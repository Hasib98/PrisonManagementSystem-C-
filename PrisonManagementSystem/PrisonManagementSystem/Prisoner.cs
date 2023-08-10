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
using System.Xml;

namespace PrisonManagementSystem
{
    public partial class Prisoner : Form
    {
        public Prisoner()
        {
            InitializeComponent();
        }
        public string Getpaths()
        {
            string path = Environment.CurrentDirectory;
            path = path.TrimEnd(new Char[] { 'b', 'i', 'n', '\\', 'D', 'e', 'b', 'u', 'g' });
            path = path + "\\Database\\PrisonManagementSystem.mdf";
            return path;
        }
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Getpaths()+";Integrated Security=True;Connect Timeout=30");
        public int PrisonerId;
        private void buttonPrisonerAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Getpaths() + ";Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("INSERT INTO PrisonerTable VALUES (@PrisonerName,@PrisonerAge,@PrisonerGender,@CrimeType)",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PrisonerName", textPrisonerName.Text);
                try
                {
                    cmd.Parameters.AddWithValue("@PrisonerAge", int.Parse(textPrisonerAge.Text));
                    cmd.Parameters.AddWithValue("@PrisonerGender", comboPrisonerGender.Text);
                    cmd.Parameters.AddWithValue("@CrimeType", textCrimeType.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //MessageBox.Show("New Prisoner Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPrisonersRecord();
                    Reset();
                }
                catch
                {
                    MessageBox.Show("Only integer value  in Age", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Prisoner all details are required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool isValid()
        {
            if(textPrisonerName.Text == string.Empty || textPrisonerAge.Text == string.Empty || comboPrisonerGender.Text == string.Empty || textCrimeType.Text == string.Empty )
            {
                return false;
            }
            return true;
        }
        private void textPrisonerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prisoner_Load(object sender, EventArgs e)
        {
            GetPrisonersRecord();
        }
        private void GetPrisonersRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Getpaths() + ";Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT * FROM PrisonerTable", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();
            dgvPrisonerList.DataSource = dt;
        }

        private void buttonPrisonerClear_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            PrisonerId = 0;
            textPrisonerName.Text = "";
            textPrisonerAge.Text = "";
            comboPrisonerGender.Text = string.Empty;
            textCrimeType.Text = "";
            textPrisonerName.Focus();
        }

        private void dgvPrisonerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PrisonerId = Convert.ToInt32(dgvPrisonerList.SelectedRows[0].Cells[0].Value); 
            textPrisonerName.Text = dgvPrisonerList.SelectedRows[0].Cells[1].Value.ToString();
            textPrisonerAge.Text = dgvPrisonerList.SelectedRows[0].Cells[2].Value.ToString();
            comboPrisonerGender.Text = dgvPrisonerList.SelectedRows[0].Cells[3].Value.ToString();
            textCrimeType.Text = dgvPrisonerList.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void buttonPrisonerUpdate_Click(object sender, EventArgs e)
        {
            if (PrisonerId > 0)
            {
                if (isValid())
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Getpaths() + ";Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand("UPDATE PrisonerTable SET PrisonerName = @PrisonerName , PrisonerAge = @PrisonerAge , PrisonerGender = @PrisonerGender , CrimeType =  @CrimeType WHERE PrisonerId=@Id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@PrisonerName", textPrisonerName.Text);
                    try
                    {
                        cmd.Parameters.AddWithValue("@PrisonerAge", int.Parse(textPrisonerAge.Text));
                        cmd.Parameters.AddWithValue("@PrisonerGender", comboPrisonerGender.Text);
                        cmd.Parameters.AddWithValue("@CrimeType", textCrimeType.Text);
                        cmd.Parameters.AddWithValue("@Id", this.PrisonerId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Prisoner details Updated", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetPrisonersRecord();
                        Reset();
                    }
                    catch
                    {
                        MessageBox.Show("Only integer value  in Age", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields to update details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a Prisoner to update details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrisonerDelete_Click(object sender, EventArgs e)
        {
            if (PrisonerId > 0)
            {
                if (MessageBox.Show("Do you want to delete this Prisoner details?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Getpaths() + ";Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand("DELETE FROM PrisonerTable WHERE PrisonerId=@Id", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Id", this.PrisonerId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Prisoner details Delete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPrisonersRecord();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Request not processed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a prisoner details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblPrisonerName_Click(object sender, EventArgs e)
        {

        }

        private void textPrisonerSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textPrisonerSearch.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Getpaths() + ";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PrisonerTable WHERE PrisonerId LIKE '%" + keyword + "%' OR PrisonerName LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPrisonerList.DataSource = dt;
        }


        private void comboPrisonerGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        Bitmap bitmap;

            
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            int height = dgvPrisonerList.Height;
            dgvPrisonerList.Height = dgvPrisonerList.RowCount * dgvPrisonerList.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgvPrisonerList.Width, dgvPrisonerList.Height);
            dgvPrisonerList.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvPrisonerList.Width, dgvPrisonerList.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgvPrisonerList.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void buttonLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagementPage().Show();
        }

        private void Prisoner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
