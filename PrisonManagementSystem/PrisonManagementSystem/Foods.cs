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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PrisonManagementSystem
{
    public partial class Foods : Form
    {
        public Foods()
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
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\PrisonManagementSystem\PrisonManagementSystem\Database\PrisonManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Getpath()+";Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("INSERT INTO Foods VALUES (@FoodItems,@Quantity)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FoodItems", txtboxitem.Text);
                //cmd.Parameters.AddWithValue("@Quantity", int.Parse(textPrisonerAge.Text));
                cmd.Parameters.AddWithValue("@Quantity", numericUpDownQty.Value);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //MessageBox.Show("New Food Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetFoodRecord();
                Reset();
            }
        }

        public void Reset()
        {
           
            txtboxitem.Text = "";
            numericUpDownQty.Value = 0;
            txtboxitem.Focus();
            
        }


        private bool isValid()
        {
            if (txtboxitem.Text == string.Empty)
            {
                MessageBox.Show("item is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Foods_Load(object sender, EventArgs e)
        {

            label1.Parent = pictureBox1;
            label1.BackColor = System.Drawing.Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = System.Drawing.Color.Transparent;
            GetFoodRecord();
        }

        private void GetFoodRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Getpath()+";Integrated Security=True;Connect Timeout=30");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Foods", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();
            dgvFoodList.DataSource = dt;
        }

        private void dgvPrisonerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Food_list.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvFoodList.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvFoodList.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            

                            foreach (DataGridViewRow row in dgvFoodList.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        
                                        pdfTable.AddCell("");
                                    }
                                    else
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }

                                    //pdfTable.AddCell(cell.Value.ToString());
                                    //MessageBox.Show(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnaBackFoodFrame_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagementPage().Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Getpath() + ";Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("DELETE FROM FOODS", con);
           // cmd.CommandType = CommandType.Text;
          //  cmd.Parameters.AddWithValue("@FoodItems", txtboxitem.Text);
            //cmd.Parameters.AddWithValue("@Quantity", int.Parse(textPrisonerAge.Text));
          //  cmd.Parameters.AddWithValue("@Quantity", numericUpDownQty.Value);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

           // MessageBox.Show("New Food Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetFoodRecord();
            Reset();
        }

        private void Foods_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
